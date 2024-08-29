namespace Library_Management_System.FORMS
{
    partial class completeBookDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(completeBookDetails));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.GreenYellow;
            label1.Location = new Point(209, 65);
            label1.Name = "label1";
            label1.Size = new Size(209, 37);
            label1.TabIndex = 0;
            label1.Text = "Book Details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(101, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 97);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(101, 166);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(805, 394);
            dataGridView2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(557, 63);
            button1.Name = "button1";
            button1.Size = new Size(155, 55);
            button1.TabIndex = 3;
            button1.Text = "Available";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(751, 65);
            button2.Name = "button2";
            button2.Size = new Size(155, 55);
            button2.TabIndex = 4;
            button2.Text = "Not Available";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // completeBookDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(1021, 611);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "completeBookDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "completeBookDetails";
            Load += completeBookDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView2;
        private Button button1;
        private Button button2;
    }
}