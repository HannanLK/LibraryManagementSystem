namespace Library_Management_System.FORMS
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            txtBookISBN = new TextBox();
            txtBookPrice = new TextBox();
            txtBookAuthor = new TextBox();
            txtBookTitle = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtBookQuantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBookQuantity).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-32, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 410);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(390, 34);
            label1.Name = "label1";
            label1.Size = new Size(168, 34);
            label1.TabIndex = 1;
            label1.Text = "Add Books";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(314, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // txtBookISBN
            // 
            txtBookISBN.Font = new Font("Segoe UI", 10.2F);
            txtBookISBN.Location = new Point(572, 276);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(250, 30);
            txtBookISBN.TabIndex = 23;
            // 
            // txtBookPrice
            // 
            txtBookPrice.Font = new Font("Segoe UI", 10.2F);
            txtBookPrice.Location = new Point(572, 332);
            txtBookPrice.Name = "txtBookPrice";
            txtBookPrice.Size = new Size(250, 30);
            txtBookPrice.TabIndex = 21;
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Font = new Font("Segoe UI", 10.2F);
            txtBookAuthor.Location = new Point(572, 223);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(250, 30);
            txtBookAuthor.TabIndex = 19;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Font = new Font("Segoe UI", 10.2F);
            txtBookTitle.Location = new Point(572, 168);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(250, 30);
            txtBookTitle.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.GradientInactiveCaption;
            label7.Location = new Point(369, 384);
            label7.Name = "label7";
            label7.Size = new Size(99, 23);
            label7.TabIndex = 17;
            label7.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.GradientInactiveCaption;
            label6.Location = new Point(369, 332);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 16;
            label6.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.GradientInactiveCaption;
            label4.Location = new Point(369, 276);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 14;
            label4.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.GradientInactiveCaption;
            label3.Location = new Point(369, 223);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 13;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(369, 168);
            label2.Name = "label2";
            label2.Size = new Size(129, 23);
            label2.TabIndex = 12;
            label2.Text = "Book Name";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(452, 467);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 39);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.LightBlue;
            btnCancel.Location = new Point(619, 467);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 39);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtBookQuantity
            // 
            txtBookQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookQuantity.Location = new Point(572, 385);
            txtBookQuantity.Name = "txtBookQuantity";
            txtBookQuantity.Size = new Size(250, 30);
            txtBookQuantity.TabIndex = 27;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 102, 85);
            ClientSize = new Size(857, 528);
            Controls.Add(txtBookQuantity);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtBookISBN);
            Controls.Add(txtBookPrice);
            Controls.Add(txtBookAuthor);
            Controls.Add(txtBookTitle);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            Load += AddBook_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBookQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txtBookISBN;
        private TextBox txtBookPrice;
        private TextBox txtBookAuthor;
        private TextBox txtBookTitle;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSave;
        private Button btnCancel;
        private NumericUpDown txtBookQuantity;
    }
}