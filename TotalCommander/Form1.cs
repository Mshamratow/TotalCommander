using System.Diagnostics;
namespace TotalCommander
{
    public partial class Form1 : Form
    {
        const int max_folders = 1000;
        const  int max_files = 1000;

        const int path_label_size = 100;
        string current_directory_left = "C:/";
        string current_directory_right = "C:/";
        int num_folders_left = 0, num_folders_right = 0;
        int num_files_left = 0, num_files_right = 0;
        Label[] folders_left = new Label[max_folders];
        Label[] folders_right = new Label[max_folders];
        Label[] files_left = new Label[max_files];
        Label[] files_right = new Label[max_files];
        public Form1()
        {
            InitializeComponent();
            ShowDirectory(panel_left, current_directory_left);
            ShowDirectory(panel_right, current_directory_right);
        }

        void ChangeUpperLabel(bool left_panel, string path)
        {
            string text = String.Format("{0, -" + path_label_size.ToString() + "}", path);
            if (left_panel)
            {
                label_path.Text = text;
            }
            else label_path2.Text = text;
        }

        void ShowDirectory(Panel panel, string directory)
        {
            if (panel.Name == "panel_left")
            {
                for (int i = 0; i < num_folders_left; i++)
                {
                    folders_left[i].Dispose();
                }
                for (int i = 0; i < num_files_left; i++)
                {
                    files_left[i].Dispose();
                }
            }
            else
            {
                for (int i = 0; i < num_folders_right; i++)
                {
                    folders_right[i].Dispose();
                }
                for (int i = 0; i < num_files_right; i++)
                {
                    files_right[i].Dispose();
                }
            }
            if (Directory.Exists(directory))
            {
                ChangeUpperLabel(panel.Name == "panel_left", directory);
                DirectoryInfo di = new DirectoryInfo(directory);
                int index = 0;
                int index2 = 0;
                if (panel.Name == "panel_left")
                {
                    foreach (FileInfo fi in di.GetFiles())
                    {
                        files_left[index] = new Label { Text = fi.Name, Font = new Font("Arial", 9), Location = new Point(0, index * 20), BackColor = Color.FromName("LightBlue"), ForeColor = Color.FromName("Blue"), BorderStyle = BorderStyle.FixedSingle, Size = new Size(600, 20) };
                        files_left[index].Parent = files_panel_left;
                        files_left[index].DoubleClick += file_label_click;
                        files_left[index].Show();
                        index++;
                    }
                    num_files_left = index;

                    foreach (var fi in di.GetDirectories())
                    {
                        folders_left[index2] = new Label { Text = fi.Name, Font = new Font("Arial", 9), Location = new Point(0, index2 * 20), BackColor = Color.FromName("LightBlue"), ForeColor = Color.FromName("Blue"), BorderStyle = BorderStyle.FixedSingle, Size = new Size(600, 20) };
                        folders_left[index2].Parent = folders_panel_left;
                        folders_left[index2].DoubleClick += folder_label_click;
                        folders_left[index2].Show();
                        index2++;
                    }
                    num_folders_left = index2;
                }
                else
                {
                    foreach (FileInfo fi in di.GetFiles())
                    {
                        files_right[index] = new Label { Text = fi.Name, Font = new Font("Arial", 9), Location = new Point(0, index * 20), BackColor = Color.FromName("LightBlue"), ForeColor = Color.FromName("Blue"), BorderStyle = BorderStyle.FixedSingle, Size = new Size(600, 20) };
                        files_right[index].Parent = files_panel_right;
                        files_right[index].DoubleClick += file_label_click;
                        files_right[index].Show();
                        index++;
                    }
                    num_files_right = index;

                    foreach (var fi in di.GetDirectories())
                    {
                        folders_right[index2] = new Label { Text = fi.Name, Font = new Font("Arial", 9), Location = new Point(0, index2 * 20), BackColor = Color.FromName("LightBlue"), ForeColor = Color.FromName("Blue"), BorderStyle = BorderStyle.FixedSingle, Size = new Size(600, 20) };
                        folders_right[index2].Parent = folders_panel_right;
                        folders_right[index2].DoubleClick += folder_label_click;
                        folders_right[index2].Show();
                        index2++;
                    }
                    num_folders_right = index2;

                }
            }
        }

        private void panel_left_Paint(object sender, PaintEventArgs e)
        {

        }

        void file_label_click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label.Parent == files_panel_left)
            {
                ProcessStartInfo psi;
                string command = $"/k \"{current_directory_left + label.Text}\"";
                psi = new ProcessStartInfo("cmd", command);
                psi.UseShellExecute = false;
                Process.Start(psi);
            }
            else
            {
                ProcessStartInfo psi;
                string command = $"/k \"{current_directory_right + label.Text}\"";
                psi = new ProcessStartInfo("cmd", command);
                psi.UseShellExecute = false;
                Process.Start(psi);
            }
        }

        void folder_label_click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label.Parent == folders_panel_left)
            {
                current_directory_left += label.Text + "/";
                ShowDirectory(panel_left, current_directory_left);
            }
            else
            {
                current_directory_right += label.Text + "/";
                ShowDirectory(panel_right, current_directory_right);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_back_left_Click(object sender, EventArgs e)
        {
            string[] folders = current_directory_left.Split("/");
            string path = "";
            for (int i = 0; i < folders.Length - 2; i++)
            {
                path += folders[i] + "/";
            }
            current_directory_left = path;
            ShowDirectory(panel_left, current_directory_left);
        }

        private void button_back_right_Click(object sender, EventArgs e)
        {
            string[] folders = current_directory_right.Split("/");
            string path = "";
            for (int i = 0; i < folders.Length - 2; i++)
            {
                path += folders[i] + "/";
            }
            current_directory_right = path;
            ShowDirectory(panel_right, current_directory_right);
        }
    }
}
