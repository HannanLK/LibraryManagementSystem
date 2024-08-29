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
    public partial class completeBookDetails : Form
    {
        public completeBookDetails()
        {
            InitializeComponent();
            dataBase db = new dataBase();
            db.LoadAllBooks(dataGridView2);
        }

        private void completeBookDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowFilteredBooks(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowFilteredBooks(false);
        }
        private void ShowFilteredBooks(bool showAvailable)
        {
            try
            {

                dataBase db = new dataBase();
                var dataTable = db.FilterBooksByQuantity(showAvailable);

                dataGridView2.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
