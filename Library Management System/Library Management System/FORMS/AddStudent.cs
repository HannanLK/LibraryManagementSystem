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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnStudentSaveinfo_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete unsaved data", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnStudentRefresh_Click(object sender, EventArgs e)
        {
            txtSudentName.Clear();
            txtStudentID.Clear();
            txtStudentContact.Clear();
            txtStudentEmail.Clear();

        }

        private void btnStudentSaveinfo_Click_1(object sender, EventArgs e)
        {
            if (txtSudentName.Text != "" && txtStudentID.Text != "" && txtStudentContact.Text != "" && txtStudentEmail.Text != "")
            {

                string sname = txtSudentName.Text;
                string sid = txtStudentID.Text;
                int sphone = int.Parse(txtStudentContact.Text);
                string semail = txtStudentEmail.Text;

                //creating student object
                Student newStudent = new Student(sname, sid, sphone, semail);
                dataBase dao = new();

                dao.insertStudent(newStudent);

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSudentName.Clear();
                txtStudentID.Clear();
                txtStudentContact.Clear();
                txtStudentEmail.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }

}
