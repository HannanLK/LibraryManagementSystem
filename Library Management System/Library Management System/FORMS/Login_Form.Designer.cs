namespace Library_Management_System.FORMS
{
    partial class Login_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txt_username = new TextBox();
            txt_password = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnLogin = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 101);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(149, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 39);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(40, 55, 71);
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.ForeColor = Color.White;
            txt_username.Location = new Point(105, 261);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "username";
            txt_username.Size = new Size(225, 29);
            txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(40, 55, 71);
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.ForeColor = Color.White;
            txt_password.Location = new Point(105, 319);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "password";
            txt_password.Size = new Size(225, 29);
            txt_password.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(105, 296);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(105, 354);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(52, 266);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(52, 326);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gold;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(105, 429);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(194, 44);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(377, 12);
            button3.Name = "button3";
            button3.Size = new Size(41, 31);
            button3.TabIndex = 10;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 55, 71);
            ClientSize = new Size(430, 615);
            Controls.Add(button3);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txt_username;
        private TextBox txt_password;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnLogin;
        private Button button3;
    }
}