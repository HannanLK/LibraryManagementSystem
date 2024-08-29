namespace Library_Management_System.FORMS
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSudentName = new TextBox();
            txtStudentID = new TextBox();
            txtStudentContact = new TextBox();
            txtStudentEmail = new TextBox();
            btnStudentRefresh = new Button();
            btnStudentSaveinfo = new Button();
            btnStudentCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-29, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 418);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(380, 32);
            label1.Name = "label1";
            label1.Size = new Size(208, 37);
            label1.TabIndex = 1;
            label1.Text = "Add Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(404, 200);
            label2.Name = "label2";
            label2.Size = new Size(157, 23);
            label2.TabIndex = 2;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(404, 257);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 3;
            label3.Text = "Student ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(404, 320);
            label5.Name = "label5";
            label5.Size = new Size(153, 23);
            label5.TabIndex = 5;
            label5.Text = "Contact Num.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(404, 377);
            label6.Name = "label6";
            label6.Size = new Size(68, 23);
            label6.TabIndex = 6;
            label6.Text = "Email";
            // 
            // txtSudentName
            // 
            txtSudentName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSudentName.Location = new Point(607, 193);
            txtSudentName.Name = "txtSudentName";
            txtSudentName.Size = new Size(230, 30);
            txtSudentName.TabIndex = 7;
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(607, 257);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(230, 30);
            txtStudentID.TabIndex = 8;
            // 
            // txtStudentContact
            // 
            txtStudentContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentContact.Location = new Point(607, 320);
            txtStudentContact.Name = "txtStudentContact";
            txtStudentContact.Size = new Size(230, 30);
            txtStudentContact.TabIndex = 10;
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentEmail.Location = new Point(607, 377);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.Size = new Size(230, 30);
            txtStudentEmail.TabIndex = 11;
            // 
            // btnStudentRefresh
            // 
            btnStudentRefresh.BackColor = Color.MidnightBlue;
            btnStudentRefresh.FlatStyle = FlatStyle.Popup;
            btnStudentRefresh.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentRefresh.ForeColor = Color.White;
            btnStudentRefresh.Location = new Point(404, 456);
            btnStudentRefresh.Name = "btnStudentRefresh";
            btnStudentRefresh.Size = new Size(125, 39);
            btnStudentRefresh.TabIndex = 12;
            btnStudentRefresh.Text = "Refresh";
            btnStudentRefresh.UseVisualStyleBackColor = false;
            btnStudentRefresh.Click += btnStudentRefresh_Click;
            // 
            // btnStudentSaveinfo
            // 
            btnStudentSaveinfo.BackColor = Color.Gold;
            btnStudentSaveinfo.FlatStyle = FlatStyle.Popup;
            btnStudentSaveinfo.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentSaveinfo.Location = new Point(561, 456);
            btnStudentSaveinfo.Name = "btnStudentSaveinfo";
            btnStudentSaveinfo.Size = new Size(125, 39);
            btnStudentSaveinfo.TabIndex = 13;
            btnStudentSaveinfo.Text = "Save Info";
            btnStudentSaveinfo.UseVisualStyleBackColor = false;
            btnStudentSaveinfo.Click += btnStudentSaveinfo_Click_1;
            // 
            // btnStudentCancel
            // 
            btnStudentCancel.BackColor = Color.OrangeRed;
            btnStudentCancel.FlatStyle = FlatStyle.Popup;
            btnStudentCancel.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentCancel.Location = new Point(712, 456);
            btnStudentCancel.Name = "btnStudentCancel";
            btnStudentCancel.Size = new Size(125, 39);
            btnStudentCancel.TabIndex = 14;
            btnStudentCancel.Text = "Cancel";
            btnStudentCancel.UseVisualStyleBackColor = false;
            btnStudentCancel.Click += btnStudentCancel_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 206, 132);
            ClientSize = new Size(888, 540);
            Controls.Add(btnStudentCancel);
            Controls.Add(btnStudentSaveinfo);
            Controls.Add(btnStudentRefresh);
            Controls.Add(txtStudentEmail);
            Controls.Add(txtStudentContact);
            Controls.Add(txtStudentID);
            Controls.Add(txtSudentName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtSudentName;
        private TextBox txtStudentID;
        private TextBox txtStudentContact;
        private TextBox txtStudentEmail;
        private Button btnStudentRefresh;
        private Button btnStudentSaveinfo;
        private Button btnStudentCancel;
    }
}