using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_System.CLASSES;
using Library_Management_System.DATABASE;
using MySql.Data.MySqlClient;

namespace Library_Management_System.FORMS
{
    public partial class View_Bookinfo : Form
    {
        public View_Bookinfo()
        {
            InitializeComponent();
            LoadAllBooks();
        }
        private void LoadAllBooks()
        {
            dataBase db = new dataBase();
            db.LoadAllBooks(dataGridView1);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void View_Bookinfo_Load(object sender, EventArgs e)
        {

        }

        private void btn_viewcancel_Click(object sender, EventArgs e)
        {
            bookinfopanel.Visible = false;

            if (MessageBox.Show("This will exit the program. Are you sure?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_viewupdate_Click(object sender, EventArgs e)
        {
            DialogResult questionResult = MessageBox.Show("Are you sure you want to update the data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (questionResult == DialogResult.Yes)
            {
                if (txtBookName.Text != "" && txtBookAuthor.Text != "" && txtBookISBN.Text != "" && txtBookPrice.Text != "" && textquantityBox.Text != "")
                {

                    string btitle = txtBookName.Text;
                    string bauthor = txtBookAuthor.Text;
                    string bisbn = txtBookISBN.Text;
                    int bquanity = int.Parse(textquantityBox.Text);
                    decimal bprice = decimal.Parse(txtBookPrice.Text);

                    //creating a Book Object
                    Book newBook = new Book(/*id*/ btitle, bauthor, bisbn, bquanity, bprice);
                    dataBase dao = new();

                    //add the book to the data base
                    dao.updateBook(newBook);

                    //clearing the form
                    MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBookName.Clear();
                    txtBookAuthor.Clear();
                    txtBookISBN.Clear();
                    txtBookPrice.Clear();

                    LoadAllBooks();

                }
                else
                {
                    MessageBox.Show("Empty Field Not Allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            dataBase db = new dataBase();
            dataGridView1.DataSource = db.SearchAndLoadData(searchText);
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtBookName.Text = selectedRow.Cells["book_title"].Value.ToString();
                txtBookAuthor.Text = selectedRow.Cells["book_author"].Value.ToString();
                txtBookISBN.Text = selectedRow.Cells["book_isbn"].Value.ToString();
                txtBookPrice.Text = selectedRow.Cells["book_price"].Value.ToString();
            }
        }


        public void SearchAndLoadData(string searchText)
        {

        }
        private void datagridview_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_viewdelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Data will be deleted! Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string bookISBNToDelete = selectedRow.Cells["book_isbn"].Value.ToString();

                    dataBase dao = new dataBase();
                    dao.DeleteBook(bookISBNToDelete);

                    dao.LoadAllBooks(dataGridView1);
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtBookName.Clear();
            txtBookAuthor.Clear();
            txtBookISBN.Clear();
            txtBookPrice.Clear();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string bookName = selectedRow.Cells["book_title"].Value.ToString();
                string bookAuthor = selectedRow.Cells["book_author"].Value.ToString();
                string bookISBN = selectedRow.Cells["book_isbn"].Value.ToString();
                string bookPrice = selectedRow.Cells["book_price"].Value.ToString();
                string bookQuantity = selectedRow.Cells["book_quantity"].Value.ToString();

                txtBookName.Text = bookName;
                txtBookAuthor.Text = bookAuthor;
                txtBookISBN.Text = bookISBN;
                txtBookPrice.Text = bookPrice;
                textquantityBox.Text = bookQuantity;
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}