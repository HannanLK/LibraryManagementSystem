namespace Library_Management_System.FORMS
{
    partial class View_Bookinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Bookinfo));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            bookinfopanel = new Panel();
            textquantityBox = new TextBox();
            findbutton = new Button();
            btn_viewcancel = new Button();
            btn_viewdelete = new Button();
            btn_viewupdate = new Button();
            txtBookISBN = new TextBox();
            txtBookPrice = new TextBox();
            txtBookAuthor = new TextBox();
            txtBookName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            bookinfopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(317, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 93);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(427, 54);
            label1.Name = "label1";
            label1.Size = new Size(163, 34);
            label1.TabIndex = 1;
            label1.Text = "View Book";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(89, 156);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 2;
            label2.Text = "Book Name ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(258, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 35);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(641, 150);
            button1.Name = "button1";
            button1.Size = new Size(104, 36);
            button1.TabIndex = 4;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // bookinfopanel
            // 
            bookinfopanel.BackColor = Color.FromArgb(17, 122, 101);
            bookinfopanel.Controls.Add(textquantityBox);
            bookinfopanel.Controls.Add(findbutton);
            bookinfopanel.Controls.Add(btn_viewcancel);
            bookinfopanel.Controls.Add(btn_viewdelete);
            bookinfopanel.Controls.Add(btn_viewupdate);
            bookinfopanel.Controls.Add(txtBookISBN);
            bookinfopanel.Controls.Add(txtBookPrice);
            bookinfopanel.Controls.Add(txtBookAuthor);
            bookinfopanel.Controls.Add(txtBookName);
            bookinfopanel.Controls.Add(label7);
            bookinfopanel.Controls.Add(label6);
            bookinfopanel.Controls.Add(label4);
            bookinfopanel.Controls.Add(label3);
            bookinfopanel.Controls.Add(label8);
            bookinfopanel.Location = new Point(12, 569);
            bookinfopanel.Name = "bookinfopanel";
            bookinfopanel.Size = new Size(849, 327);
            bookinfopanel.TabIndex = 6;
            // 
            // textquantityBox
            // 
            textquantityBox.Font = new Font("Segoe UI", 10.2F);
            textquantityBox.Location = new Point(367, 173);
            textquantityBox.Name = "textquantityBox";
            textquantityBox.Size = new Size(250, 30);
            textquantityBox.TabIndex = 41;
            // 
            // findbutton
            // 
            findbutton.BackColor = Color.LightGoldenrodYellow;
            findbutton.Cursor = Cursors.Hand;
            findbutton.FlatStyle = FlatStyle.Popup;
            findbutton.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Bold);
            findbutton.Location = new Point(630, 244);
            findbutton.Name = "findbutton";
            findbutton.Size = new Size(121, 46);
            findbutton.TabIndex = 40;
            findbutton.Text = "Load info";
            findbutton.UseVisualStyleBackColor = false;
            findbutton.Click += button2_Click;
            // 
            // btn_viewcancel
            // 
            btn_viewcancel.BackColor = SystemColors.ActiveCaptionText;
            btn_viewcancel.Cursor = Cursors.Hand;
            btn_viewcancel.FlatStyle = FlatStyle.Popup;
            btn_viewcancel.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Bold);
            btn_viewcancel.ForeColor = SystemColors.ActiveCaption;
            btn_viewcancel.Location = new Point(481, 244);
            btn_viewcancel.Name = "btn_viewcancel";
            btn_viewcancel.Size = new Size(96, 46);
            btn_viewcancel.TabIndex = 38;
            btn_viewcancel.Text = "Cancel";
            btn_viewcancel.UseVisualStyleBackColor = false;
            btn_viewcancel.Click += btn_viewcancel_Click;
            // 
            // btn_viewdelete
            // 
            btn_viewdelete.BackColor = Color.OrangeRed;
            btn_viewdelete.Cursor = Cursors.Hand;
            btn_viewdelete.FlatStyle = FlatStyle.Popup;
            btn_viewdelete.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Bold);
            btn_viewdelete.ForeColor = Color.White;
            btn_viewdelete.Location = new Point(331, 244);
            btn_viewdelete.Name = "btn_viewdelete";
            btn_viewdelete.Size = new Size(96, 46);
            btn_viewdelete.TabIndex = 37;
            btn_viewdelete.Text = "Delete";
            btn_viewdelete.UseVisualStyleBackColor = false;
            btn_viewdelete.Click += btn_viewdelete_Click;
            // 
            // btn_viewupdate
            // 
            btn_viewupdate.BackColor = Color.Gold;
            btn_viewupdate.Cursor = Cursors.Hand;
            btn_viewupdate.FlatStyle = FlatStyle.Popup;
            btn_viewupdate.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Bold);
            btn_viewupdate.Location = new Point(177, 244);
            btn_viewupdate.Name = "btn_viewupdate";
            btn_viewupdate.Size = new Size(96, 46);
            btn_viewupdate.TabIndex = 7;
            btn_viewupdate.Text = "Update";
            btn_viewupdate.UseVisualStyleBackColor = false;
            btn_viewupdate.Click += btn_viewupdate_Click;
            // 
            // txtBookISBN
            // 
            txtBookISBN.Font = new Font("Segoe UI", 10.2F);
            txtBookISBN.Location = new Point(177, 106);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(250, 30);
            txtBookISBN.TabIndex = 35;
            // 
            // txtBookPrice
            // 
            txtBookPrice.Font = new Font("Segoe UI", 10.2F);
            txtBookPrice.Location = new Point(583, 101);
            txtBookPrice.Name = "txtBookPrice";
            txtBookPrice.Size = new Size(250, 30);
            txtBookPrice.TabIndex = 34;
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Font = new Font("Segoe UI", 10.2F);
            txtBookAuthor.Location = new Point(583, 40);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(250, 30);
            txtBookAuthor.TabIndex = 32;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 10.2F);
            txtBookName.Location = new Point(177, 40);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(250, 30);
            txtBookName.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.GradientInactiveCaption;
            label7.Location = new Point(231, 174);
            label7.Name = "label7";
            label7.Size = new Size(99, 23);
            label7.TabIndex = 30;
            label7.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.GradientInactiveCaption;
            label6.Location = new Point(456, 113);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 29;
            label6.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.GradientInactiveCaption;
            label4.Location = new Point(30, 108);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 27;
            label4.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.GradientInactiveCaption;
            label3.Location = new Point(456, 47);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 26;
            label3.Text = "Author";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.GradientInactiveCaption;
            label8.Location = new Point(23, 40);
            label8.Name = "label8";
            label8.Size = new Size(129, 23);
            label8.TabIndex = 25;
            label8.Text = "Book Name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 320);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // View_Bookinfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 10);
            BackColor = Color.FromArgb(19, 141, 117);
            ClientSize = new Size(893, 575);
            Controls.Add(dataGridView1);
            Controls.Add(bookinfopanel);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "View_Bookinfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Bookinfo";
            Load += View_Bookinfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            bookinfopanel.ResumeLayout(false);
            bookinfopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Panel bookinfopanel;
        private TextBox txtBookISBN;
        private TextBox txtBookPrice;
        private TextBox txtBookAuthor;
        private TextBox txtBookName;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label8;
        private Button btn_viewdelete;
        private Button btn_viewupdate;
        private Button btn_viewcancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
        private Button findbutton;
        private TextBox textquantityBox;
    }
}