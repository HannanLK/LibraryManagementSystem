namespace Library_Management_System.FORMS
{
    partial class ViewStudentinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentinfo));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            btnsearchstudent = new Button();
            panel2 = new Panel();
            btn_findStudent = new Button();
            txtStudentEmail = new TextBox();
            txtStudentContact = new TextBox();
            txtStudentID = new TextBox();
            txtSudentName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnstudentCancel = new Button();
            btnStudentDelete = new Button();
            btnStudentUpdate = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(298, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 108);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(397, 58);
            label1.Name = "label1";
            label1.Size = new Size(219, 37);
            label1.TabIndex = 1;
            label1.Text = "View Student";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(273, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 30);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 161);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 3;
            label2.Text = "Student ID";
            // 
            // btnsearchstudent
            // 
            btnsearchstudent.BackColor = Color.Gold;
            btnsearchstudent.Cursor = Cursors.Hand;
            btnsearchstudent.FlatStyle = FlatStyle.Popup;
            btnsearchstudent.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsearchstudent.Location = new Point(707, 155);
            btnsearchstudent.Name = "btnsearchstudent";
            btnsearchstudent.Size = new Size(94, 34);
            btnsearchstudent.TabIndex = 4;
            btnsearchstudent.Text = "Search";
            btnsearchstudent.UseVisualStyleBackColor = false;
            btnsearchstudent.Click += btnsearchstudent_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(btn_findStudent);
            panel2.Controls.Add(txtStudentEmail);
            panel2.Controls.Add(txtStudentContact);
            panel2.Controls.Add(txtStudentID);
            panel2.Controls.Add(txtSudentName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnstudentCancel);
            panel2.Controls.Add(btnStudentDelete);
            panel2.Controls.Add(btnStudentUpdate);
            panel2.Location = new Point(43, 572);
            panel2.Name = "panel2";
            panel2.Size = new Size(836, 305);
            panel2.TabIndex = 5;
            // 
            // btn_findStudent
            // 
            btn_findStudent.BackColor = Color.LightGoldenrodYellow;
            btn_findStudent.Cursor = Cursors.Hand;
            btn_findStudent.FlatStyle = FlatStyle.Popup;
            btn_findStudent.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_findStudent.ForeColor = Color.Black;
            btn_findStudent.Location = new Point(580, 213);
            btn_findStudent.Name = "btn_findStudent";
            btn_findStudent.Size = new Size(110, 52);
            btn_findStudent.TabIndex = 17;
            btn_findStudent.Text = "Load info";
            btn_findStudent.UseVisualStyleBackColor = false;
            btn_findStudent.Click += btn_findStudent_Click;
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentEmail.Location = new Point(558, 125);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.Size = new Size(230, 30);
            txtStudentEmail.TabIndex = 16;
            // 
            // txtStudentContact
            // 
            txtStudentContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentContact.Location = new Point(184, 118);
            txtStudentContact.Name = "txtStudentContact";
            txtStudentContact.Size = new Size(230, 30);
            txtStudentContact.TabIndex = 15;
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(558, 44);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(230, 30);
            txtStudentID.TabIndex = 14;
            // 
            // txtSudentName
            // 
            txtSudentName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSudentName.Location = new Point(184, 44);
            txtSudentName.Name = "txtSudentName";
            txtSudentName.Size = new Size(230, 30);
            txtSudentName.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(484, 125);
            label6.Name = "label6";
            label6.Size = new Size(68, 23);
            label6.TabIndex = 12;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 118);
            label5.Name = "label5";
            label5.Size = new Size(153, 23);
            label5.TabIndex = 11;
            label5.Text = "Contact Num.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(432, 46);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 10;
            label3.Text = "Student ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 44);
            label4.Name = "label4";
            label4.Size = new Size(157, 23);
            label4.TabIndex = 9;
            label4.Text = "Student Name";
            // 
            // btnstudentCancel
            // 
            btnstudentCancel.BackColor = Color.Black;
            btnstudentCancel.Cursor = Cursors.Hand;
            btnstudentCancel.FlatStyle = FlatStyle.Popup;
            btnstudentCancel.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstudentCancel.ForeColor = SystemColors.ActiveCaption;
            btnstudentCancel.Location = new Point(432, 213);
            btnstudentCancel.Name = "btnstudentCancel";
            btnstudentCancel.Size = new Size(112, 52);
            btnstudentCancel.TabIndex = 8;
            btnstudentCancel.Text = "Cancel";
            btnstudentCancel.UseVisualStyleBackColor = false;
            // 
            // btnStudentDelete
            // 
            btnStudentDelete.BackColor = Color.Red;
            btnStudentDelete.Cursor = Cursors.Hand;
            btnStudentDelete.FlatStyle = FlatStyle.Popup;
            btnStudentDelete.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentDelete.ForeColor = Color.White;
            btnStudentDelete.Location = new Point(278, 213);
            btnStudentDelete.Name = "btnStudentDelete";
            btnStudentDelete.Size = new Size(118, 52);
            btnStudentDelete.TabIndex = 7;
            btnStudentDelete.Text = "Delete";
            btnStudentDelete.UseVisualStyleBackColor = false;
            btnStudentDelete.Click += btnStudentDelete_Click;
            // 
            // btnStudentUpdate
            // 
            btnStudentUpdate.BackColor = Color.Gold;
            btnStudentUpdate.Cursor = Cursors.Hand;
            btnStudentUpdate.FlatStyle = FlatStyle.Popup;
            btnStudentUpdate.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentUpdate.Location = new Point(128, 213);
            btnStudentUpdate.Name = "btnStudentUpdate";
            btnStudentUpdate.Size = new Size(110, 52);
            btnStudentUpdate.TabIndex = 6;
            btnStudentUpdate.Text = "Update";
            btnStudentUpdate.UseVisualStyleBackColor = false;
            btnStudentUpdate.Click += btnStudentUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(123, 222);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 310);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ViewStudentinfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 10);
            BackColor = Color.CadetBlue;
            ClientSize = new Size(929, 654);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(btnsearchstudent);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ViewStudentinfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudentinfo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button btnsearchstudent;
        private Panel panel2;
        private Button btnStudentUpdate;
        private Button btnStudentDelete;
        private Button btnstudentCancel;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox txtStudentEmail;
        private TextBox txtStudentContact;
        private TextBox txtStudentID;
        private TextBox txtSudentName;
        private DataGridView dataGridView1;
        private Button btn_findStudent;
    }
}