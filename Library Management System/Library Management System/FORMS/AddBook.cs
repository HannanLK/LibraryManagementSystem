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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookTitle.Text != "" && txtBookAuthor.Text != "" && txtBookISBN.Text != "" && txtBookPrice.Text != "" && txtBookQuantity.Text != "")
            {

                string btitle = txtBookTitle.Text;
                string bauthor = txtBookAuthor.Text;
                string bisbn = txtBookISBN.Text;
                int bquanity = int.Parse(txtBookQuantity.Text);
                decimal bprice = decimal.Parse(txtBookPrice.Text);

                //creating a Book Object
                Book newBook = new Book(/*id*/ btitle, bauthor, bisbn, bquanity, bprice);
                dataBase dao = new();

                dao.insertBook(newBook);

                //add the book to the data base

                //clearing the form for the next entry
                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookTitle.Clear();
                txtBookAuthor.Clear();
                txtBookISBN.Clear();
                txtBookPrice.Clear();

            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete unsaved data", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
