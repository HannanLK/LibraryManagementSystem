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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System.FORMS
{
    public partial class returnBook : Form
    {
        public returnBook()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(returnBookid.Text);
            int quantityToReturn = Convert.ToInt32(returnBookquantity.Text);

            dataBase db = new dataBase();
            db.ReturnBookQuantity(bookId, quantityToReturn);
            deleteReturn();

            returnBookid.Clear();
            returnBookquantity.Clear();
        }
        public void deleteReturn()
        {
            int bookIdToDelete = Convert.ToInt32(returnBookid.Text);
            dataBase db = new dataBase();
            db.DeleteBookReturnRecord(bookIdToDelete);
        }
        private void returnBookid_TextChanged(object sender, EventArgs e)
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
