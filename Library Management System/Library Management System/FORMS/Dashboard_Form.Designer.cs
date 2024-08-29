namespace Library_Management_System.FORMS
{
    partial class Dashboard_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Form));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addBookToolStripMenuItem = new ToolStripMenuItem();
            removeBookToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentInfoToolStripMenuItem = new ToolStripMenuItem();
            issueBookToolStripMenuItem = new ToolStripMenuItem();
            returnBookToolStripMenuItem = new ToolStripMenuItem();
            completeBookDetailsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(253, 235, 208);
            menuStrip1.Font = new Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentToolStripMenuItem, issueBookToolStripMenuItem, returnBookToolStripMenuItem, completeBookDetailsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1418, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.BackgroundImageLayout = ImageLayout.Center;
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBookToolStripMenuItem, removeBookToolStripMenuItem });
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(164, 54);
            booksToolStripMenuItem.Text = "Books";
            // 
            // addBookToolStripMenuItem
            // 
            addBookToolStripMenuItem.Image = (Image)resources.GetObject("addBookToolStripMenuItem.Image");
            addBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            addBookToolStripMenuItem.Size = new Size(338, 56);
            addBookToolStripMenuItem.Text = "Add New Book";
            addBookToolStripMenuItem.Click += addBookToolStripMenuItem_Click;
            // 
            // removeBookToolStripMenuItem
            // 
            removeBookToolStripMenuItem.Image = (Image)resources.GetObject("removeBookToolStripMenuItem.Image");
            removeBookToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            removeBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            removeBookToolStripMenuItem.Name = "removeBookToolStripMenuItem";
            removeBookToolStripMenuItem.Size = new Size(338, 56);
            removeBookToolStripMenuItem.Text = "View Book";
            removeBookToolStripMenuItem.Click += removeBookToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewStudentInfoToolStripMenuItem });
            studentToolStripMenuItem.Image = (Image)resources.GetObject("studentToolStripMenuItem.Image");
            studentToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            studentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(190, 54);
            studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Image = (Image)resources.GetObject("addStudentToolStripMenuItem.Image");
            addStudentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(391, 56);
            addStudentToolStripMenuItem.Text = "Add Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // viewStudentInfoToolStripMenuItem
            // 
            viewStudentInfoToolStripMenuItem.Image = (Image)resources.GetObject("viewStudentInfoToolStripMenuItem.Image");
            viewStudentInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewStudentInfoToolStripMenuItem.Name = "viewStudentInfoToolStripMenuItem";
            viewStudentInfoToolStripMenuItem.Size = new Size(391, 56);
            viewStudentInfoToolStripMenuItem.Text = "View Student Info";
            viewStudentInfoToolStripMenuItem.Click += viewStudentInfoToolStripMenuItem_Click;
            // 
            // issueBookToolStripMenuItem
            // 
            issueBookToolStripMenuItem.Image = (Image)resources.GetObject("issueBookToolStripMenuItem.Image");
            issueBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            issueBookToolStripMenuItem.Size = new Size(237, 54);
            issueBookToolStripMenuItem.Text = "Issue Book";
            issueBookToolStripMenuItem.Click += issueBookToolStripMenuItem_Click;
            // 
            // returnBookToolStripMenuItem
            // 
            returnBookToolStripMenuItem.Image = (Image)resources.GetObject("returnBookToolStripMenuItem.Image");
            returnBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            returnBookToolStripMenuItem.Size = new Size(254, 54);
            returnBookToolStripMenuItem.Text = "Return Book";
            returnBookToolStripMenuItem.Click += returnBookToolStripMenuItem_Click;
            // 
            // completeBookDetailsToolStripMenuItem
            // 
            completeBookDetailsToolStripMenuItem.Image = (Image)resources.GetObject("completeBookDetailsToolStripMenuItem.Image");
            completeBookDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            completeBookDetailsToolStripMenuItem.Name = "completeBookDetailsToolStripMenuItem";
            completeBookDetailsToolStripMenuItem.Size = new Size(237, 54);
            completeBookDetailsToolStripMenuItem.Text = "Availability";
            completeBookDetailsToolStripMenuItem.Click += completeBookDetailsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(134, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Dashboard_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1418, 633);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard_Form";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Form_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private ToolStripMenuItem removeBookToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentInfoToolStripMenuItem;
        private ToolStripMenuItem issueBookToolStripMenuItem;
        private ToolStripMenuItem returnBookToolStripMenuItem;
        private ToolStripMenuItem completeBookDetailsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}