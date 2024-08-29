using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.FORMS
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {

            InitializeComponent();
            //if (true)
            //{
            //    this.addBookToolStripMenuItem.HideDropDown();
            //}
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addbookform = new AddBook();
            addbookform.Show();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Bookinfo viewbookform = new View_Bookinfo();
            viewbookform.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addstudentform = new AddStudent();
            addstudentform.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentinfo viewstudentinfoform = new ViewStudentinfo();
            viewstudentinfoform.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issueBook viewissuebookform = new issueBook();
            viewissuebookform.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnBook viewreturnbookform = new returnBook();
            viewreturnbookform.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            completeBookDetails viewbookdetailsform = new completeBookDetails();
            viewbookdetailsform.Show();
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
