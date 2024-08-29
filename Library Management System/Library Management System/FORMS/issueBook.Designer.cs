namespace Library_Management_System.FORMS
{
    partial class issueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issueBook));
            label1 = new Label();
            btn_issue = new Button();
            idTextBox = new TextBox();
            bquantityTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            bookTitle = new TextBox();
            bookAuthor = new TextBox();
            bookisbn = new TextBox();
            bookstudentNo = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 43);
            label1.Name = "label1";
            label1.Size = new Size(182, 37);
            label1.TabIndex = 0;
            label1.Text = "Issue Book";
            // 
            // btn_issue
            // 
            btn_issue.BackColor = Color.MidnightBlue;
            btn_issue.FlatStyle = FlatStyle.Popup;
            btn_issue.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_issue.ForeColor = Color.White;
            btn_issue.Location = new Point(188, 471);
            btn_issue.Name = "btn_issue";
            btn_issue.Size = new Size(137, 44);
            btn_issue.TabIndex = 1;
            btn_issue.Text = "Issue Book";
            btn_issue.UseVisualStyleBackColor = false;
            btn_issue.Click += btn_issue_Click;
            // 
            // idTextBox
            // 
            idTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idTextBox.Location = new Point(61, 186);
            idTextBox.Margin = new Padding(3, 4, 3, 4);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(231, 34);
            idTextBox.TabIndex = 2;
            idTextBox.TextChanged += idTextBox_TextChanged;
            // 
            // bquantityTextBox
            // 
            bquantityTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bquantityTextBox.Location = new Point(416, 186);
            bquantityTextBox.Margin = new Padding(3, 4, 3, 4);
            bquantityTextBox.Name = "bquantityTextBox";
            bquantityTextBox.Size = new Size(231, 34);
            bquantityTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 151);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 4;
            label2.Text = "Book ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(416, 151);
            label3.Name = "label3";
            label3.Size = new Size(108, 31);
            label3.TabIndex = 5;
            label3.Text = "Quantity";
            // 
            // bookTitle
            // 
            bookTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookTitle.Location = new Point(61, 279);
            bookTitle.Margin = new Padding(3, 4, 3, 4);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(231, 34);
            bookTitle.TabIndex = 6;
            // 
            // bookAuthor
            // 
            bookAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookAuthor.Location = new Point(416, 279);
            bookAuthor.Margin = new Padding(3, 4, 3, 4);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(231, 34);
            bookAuthor.TabIndex = 7;
            // 
            // bookisbn
            // 
            bookisbn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookisbn.Location = new Point(61, 382);
            bookisbn.Margin = new Padding(3, 4, 3, 4);
            bookisbn.Name = "bookisbn";
            bookisbn.Size = new Size(231, 34);
            bookisbn.TabIndex = 8;
            // 
            // bookstudentNo
            // 
            bookstudentNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookstudentNo.Location = new Point(416, 382);
            bookstudentNo.Margin = new Padding(3, 4, 3, 4);
            bookstudentNo.Name = "bookstudentNo";
            bookstudentNo.Size = new Size(231, 34);
            bookstudentNo.TabIndex = 10;
            bookstudentNo.TextChanged += textBox5_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 244);
            label4.Name = "label4";
            label4.Size = new Size(62, 31);
            label4.TabIndex = 11;
            label4.Text = "Title";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(61, 347);
            label6.Name = "label6";
            label6.Size = new Size(129, 31);
            label6.TabIndex = 13;
            label6.Text = "Book ISBN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(422, 244);
            label7.Name = "label7";
            label7.Size = new Size(90, 31);
            label7.TabIndex = 12;
            label7.Text = "Author";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(422, 347);
            label8.Name = "label8";
            label8.Size = new Size(142, 31);
            label8.TabIndex = 15;
            label8.Text = "Student No.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(219, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 107);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(387, 471);
            button1.Name = "button1";
            button1.Size = new Size(137, 44);
            button1.TabIndex = 17;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // issueBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(712, 540);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(bookstudentNo);
            Controls.Add(bookisbn);
            Controls.Add(bookAuthor);
            Controls.Add(bookTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bquantityTextBox);
            Controls.Add(idTextBox);
            Controls.Add(btn_issue);
            Controls.Add(label1);
            Name = "issueBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "issueBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_issue;
        private TextBox idTextBox;
        private TextBox bquantityTextBox;
        private Label label2;
        private Label label3;
        private TextBox bookTitle;
        private TextBox bookAuthor;
        private TextBox bookisbn;
        private TextBox bookstudentNo;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Button button1;
    }
}