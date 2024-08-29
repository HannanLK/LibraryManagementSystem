using Library_Management_System.CLASSES;
using Library_Management_System.DATABASE;
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
    public partial class issueBook : Form
    {
        public issueBook()
        {
            InitializeComponent();
        }

        private void btn_issue_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(idTextBox.Text);
            int quantityToSubtract = Convert.ToInt32(bquantityTextBox.Text);

            dataBase db = new dataBase();
            db.SubtractBookQuantity(bookId, quantityToSubtract);
            insertReturnIssueBook();


        }

        public void insertReturnIssueBook()
        {
            int bookId = Convert.ToInt32(idTextBox.Text);
            int quantityToSubtract = Convert.ToInt32(bquantityTextBox.Text);
            string btitle = bookTitle.Text;
            string bauthor = bookAuthor.Text;
            string bisbn = bookisbn.Text;
            int bquanity = int.Parse(bquantityTextBox.Text);
            string studentNo = bookstudentNo.Text;
            //decimal studentNo = decimal.Parse(bookstudentNo.Text);

            dataBase db = new dataBase();
            db.InsertBookReturn(bookId, quantityToSubtract, btitle, bauthor, bisbn, bquanity, studentNo);

            idTextBox.Clear();
            bquantityTextBox.Clear();
            bookTitle.Clear();
            bookAuthor.Clear();
            bookisbn.Clear();
            bookstudentNo.Clear();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete unsaved data", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
