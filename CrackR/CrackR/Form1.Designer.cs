namespace CrackR
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.input_txt = new System.Windows.Forms.TextBox();
            this.enter_btn = new System.Windows.Forms.Button();
            this.file_name = new System.Windows.Forms.TextBox();
            this.path_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.full_path = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // input_txt
            // 
            this.input_txt.Location = new System.Drawing.Point(12, 154);
            this.input_txt.Name = "input_txt";
            this.input_txt.Size = new System.Drawing.Size(288, 23);
            this.input_txt.TabIndex = 0;
            // 
            // enter_btn
            // 
            this.enter_btn.Location = new System.Drawing.Point(225, 183);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(75, 23);
            this.enter_btn.TabIndex = 1;
            this.enter_btn.Text = "GO!";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // file_name
            // 
            this.file_name.Location = new System.Drawing.Point(13, 99);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(287, 23);
            this.file_name.TabIndex = 2;
            // 
            // path_txt
            // 
            this.path_txt.Location = new System.Drawing.Point(12, 30);
            this.path_txt.Name = "path_txt";
            this.path_txt.Size = new System.Drawing.Size(288, 23);
            this.path_txt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // full_path
            // 
            this.full_path.AutoSize = true;
            this.full_path.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.full_path.Location = new System.Drawing.Point(12, 231);
            this.full_path.Name = "full_path";
            this.full_path.Size = new System.Drawing.Size(0, 13);
            this.full_path.TabIndex = 5;
            this.full_path.Click += new System.EventHandler(this.full_path_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter File Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Website Url";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(12, 244);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(119, 15);
            this.link.TabIndex = 9;
            this.link.TabStop = true;
            this.link.Text = "More from developer";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 265);
            this.Controls.Add(this.link);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.full_path);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.path_txt);
            this.Controls.Add(this.file_name);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.input_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrackR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox input_txt;
        private Button enter_btn;
        private TextBox file_name;
        private TextBox path_txt;
        private Button button1;
        private Label full_path;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel link;
    }
}