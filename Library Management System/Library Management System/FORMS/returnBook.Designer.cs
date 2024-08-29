namespace Library_Management_System.FORMS
{
    partial class returnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(returnBook));
            label1 = new Label();
            btn_return = new Button();
            label3 = new Label();
            label2 = new Label();
            returnBookquantity = new TextBox();
            returnBookid = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkKhaki;
            label1.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(352, 61);
            label1.Name = "label1";
            label1.Size = new Size(205, 37);
            label1.TabIndex = 0;
            label1.Text = "Return Book";
            // 
            // btn_return
            // 
            btn_return.BackColor = Color.Yellow;
            btn_return.FlatStyle = FlatStyle.Popup;
            btn_return.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_return.Location = new Point(163, 324);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(157, 44);
            btn_return.TabIndex = 2;
            btn_return.Text = "Return Book";
            btn_return.UseVisualStyleBackColor = false;
            btn_return.Click += btn_return_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(431, 164);
            label3.Name = "label3";
            label3.Size = new Size(170, 31);
            label3.TabIndex = 9;
            label3.Text = "Book Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 164);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 8;
            label2.Text = "Book ID";
            // 
            // returnBookquantity
            // 
            returnBookquantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnBookquantity.Location = new Point(431, 211);
            returnBookquantity.Margin = new Padding(3, 4, 3, 4);
            returnBookquantity.Name = "returnBookquantity";
            returnBookquantity.Size = new Size(264, 34);
            returnBookquantity.TabIndex = 7;
            // 
            // returnBookid
            // 
            returnBookid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnBookid.Location = new Point(56, 211);
            returnBookid.Margin = new Padding(3, 4, 3, 4);
            returnBookid.Name = "returnBookid";
            returnBookid.Size = new Size(264, 34);
            returnBookid.TabIndex = 6;
            returnBookid.TextChanged += returnBookid_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(237, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 103);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(383, 324);
            button1.Name = "button1";
            button1.Size = new Size(157, 44);
            button1.TabIndex = 11;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // returnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(756, 484);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(returnBookquantity);
            Controls.Add(returnBookid);
            Controls.Add(btn_return);
            Controls.Add(label1);
            Name = "returnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "returnBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_return;
        private Label label3;
        private Label label2;
        private TextBox returnBookquantity;
        private TextBox returnBookid;
        private PictureBox pictureBox1;
        private Button button1;
    }
}