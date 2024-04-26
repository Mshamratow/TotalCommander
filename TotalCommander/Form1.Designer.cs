namespace TotalCommander
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_left = new Panel();
            button_back_left = new Button();
            folders_panel_left = new Panel();
            label3 = new Label();
            files_panel_left = new Panel();
            label1 = new Label();
            label_path = new Label();
            panel_right = new Panel();
            button_back_right = new Button();
            folders_panel_right = new Panel();
            label4 = new Label();
            files_panel_right = new Panel();
            label2 = new Label();
            label_path2 = new Label();
            panel_left.SuspendLayout();
            panel_right.SuspendLayout();
            SuspendLayout();
            // 
            // panel_left
            // 
            panel_left.BorderStyle = BorderStyle.FixedSingle;
            panel_left.Controls.Add(button_back_left);
            panel_left.Controls.Add(folders_panel_left);
            panel_left.Controls.Add(label3);
            panel_left.Controls.Add(files_panel_left);
            panel_left.Controls.Add(label1);
            panel_left.Controls.Add(label_path);
            panel_left.ForeColor = Color.LimeGreen;
            panel_left.Location = new Point(12, 12);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(645, 781);
            panel_left.TabIndex = 0;
            panel_left.Paint += panel_left_Paint;
            // 
            // button_back_left
            // 
            button_back_left.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_back_left.Location = new Point(545, 12);
            button_back_left.Name = "button_back_left";
            button_back_left.Size = new Size(71, 36);
            button_back_left.TabIndex = 4;
            button_back_left.Text = "←";
            button_back_left.UseVisualStyleBackColor = true;
            button_back_left.Click += button_back_left_Click;
            // 
            // folders_panel_left
            // 
            folders_panel_left.Location = new Point(17, 446);
            folders_panel_left.Name = "folders_panel_left";
            folders_panel_left.Size = new Size(599, 324);
            folders_panel_left.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 404);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 3;
            label3.Text = "Папки:";
            // 
            // files_panel_left
            // 
            files_panel_left.Location = new Point(17, 99);
            files_panel_left.Name = "files_panel_left";
            files_panel_left.Size = new Size(599, 287);
            files_panel_left.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 57);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 1;
            label1.Text = "Файлы:";
            label1.Click += label1_Click;
            // 
            // label_path
            // 
            label_path.AutoSize = true;
            label_path.BackColor = Color.DeepSkyBlue;
            label_path.BorderStyle = BorderStyle.FixedSingle;
            label_path.Font = new Font("Segoe UI", 14F);
            label_path.ForeColor = Color.Lime;
            label_path.Location = new Point(17, 18);
            label_path.Name = "label_path";
            label_path.Size = new Size(65, 27);
            label_path.TabIndex = 0;
            label_path.Text = "label1";
            // 
            // panel_right
            // 
            panel_right.BorderStyle = BorderStyle.FixedSingle;
            panel_right.Controls.Add(button_back_right);
            panel_right.Controls.Add(folders_panel_right);
            panel_right.Controls.Add(label4);
            panel_right.Controls.Add(files_panel_right);
            panel_right.Controls.Add(label2);
            panel_right.Controls.Add(label_path2);
            panel_right.Location = new Point(803, 12);
            panel_right.Name = "panel_right";
            panel_right.Size = new Size(642, 781);
            panel_right.TabIndex = 1;
            // 
            // button_back_right
            // 
            button_back_right.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_back_right.ForeColor = Color.LimeGreen;
            button_back_right.Location = new Point(554, 12);
            button_back_right.Name = "button_back_right";
            button_back_right.Size = new Size(71, 36);
            button_back_right.TabIndex = 6;
            button_back_right.Text = "←";
            button_back_right.UseVisualStyleBackColor = true;
            button_back_right.Click += button_back_right_Click;
            // 
            // folders_panel_right
            // 
            folders_panel_right.Location = new Point(16, 446);
            folders_panel_right.Name = "folders_panel_right";
            folders_panel_right.Size = new Size(609, 324);
            folders_panel_right.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.LimeGreen;
            label4.Location = new Point(16, 404);
            label4.Name = "label4";
            label4.Size = new Size(78, 30);
            label4.TabIndex = 4;
            label4.Text = "Папки:";
            // 
            // files_panel_right
            // 
            files_panel_right.Location = new Point(16, 99);
            files_panel_right.Name = "files_panel_right";
            files_panel_right.Size = new Size(609, 287);
            files_panel_right.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 2;
            label2.Text = "Файлы:";
            // 
            // label_path2
            // 
            label_path2.AutoSize = true;
            label_path2.BackColor = Color.DeepSkyBlue;
            label_path2.BorderStyle = BorderStyle.FixedSingle;
            label_path2.Font = new Font("Segoe UI", 14F);
            label_path2.ForeColor = Color.Lime;
            label_path2.Location = new Point(16, 18);
            label_path2.Name = "label_path2";
            label_path2.Size = new Size(65, 27);
            label_path2.TabIndex = 1;
            label_path2.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 795);
            Controls.Add(panel_right);
            Controls.Add(panel_left);
            Name = "Form1";
            Text = "Form1";
            panel_left.ResumeLayout(false);
            panel_left.PerformLayout();
            panel_right.ResumeLayout(false);
            panel_right.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_left;
        private Panel panel_right;
        private Label label_path;
        private Label label_path2;
        private Label label1;
        private Label label2;
        private Panel folders_panel_left;
        private Label label3;
        private Panel files_panel_left;
        private Panel folders_panel_right;
        private Label label4;
        private Panel files_panel_right;
        private Button button_back_left;
        private Button button_back_right;
    }
}
