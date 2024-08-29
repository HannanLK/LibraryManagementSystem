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
    public partial class ViewStudentinfo : Form
    {
        public ViewStudentinfo()
        {
            InitializeComponent();
            LoadAllStudents();

        }

        private void LoadAllStudents()
        {
            dataBase db = new dataBase();
            db.LoadAllStudents(dataGridView1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtSudentName.Text = selectedRow.Cells["student_name"].Value.ToString();
                txtStudentID.Text = selectedRow.Cells["student_id"].Value.ToString();
                txtStudentContact.Text = selectedRow.Cells["student_contact"].Value.ToString();
                txtStudentEmail.Text = selectedRow.Cells["student_email"].Value.ToString();
            }
        }

        private void ViewStudentinfo_Load(object sender, EventArgs e)
        {

        }

        private void btnsearchstudent_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            dataBase db = new dataBase();
            dataGridView1.DataSource = db.SearchStudentData(searchText);
        }

        private void btn_findStudent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string studentName = selectedRow.Cells["student_name"].Value.ToString();
                string studentID = selectedRow.Cells["student_id"].Value.ToString();
                string studentContact = selectedRow.Cells["student_contact"].Value.ToString();
                string studentEmail = selectedRow.Cells["student_email"].Value.ToString();

                txtSudentName.Text = studentName;
                txtStudentID.Text = studentID;
                txtStudentContact.Text = studentContact;
                txtStudentEmail.Text = studentEmail;

            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //update student details
        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            if (txtSudentName.Text != "" && txtStudentID.Text != "" && txtStudentContact.Text != "" && txtStudentEmail.Text != "")
            {
                string studentName = txtSudentName.Text;
                string studentID = txtStudentID.Text;
                int studentContact = int.Parse(txtStudentContact.Text);
                string studentEmail = txtStudentEmail.Text;

                // Creating a Student object
                Student updatedStudent = new Student(studentName, studentID, studentContact, studentEmail);

                dataBase dao = new dataBase();

                // Calling the updateStudent function in your dataBase class
                dao.UpdateStudent(updatedStudent);

                MessageBox.Show("Student data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSudentName.Clear();
                txtStudentID.Clear();
                txtStudentContact.Clear();
                txtStudentEmail.Clear();

                LoadAllStudents();
            }
            else
            {
                MessageBox.Show("Empty fields not allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //delete student details
        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string studentIDToDelete = selectedRow.Cells["student_id"].Value.ToString();

                dataBase dao = new dataBase();
                dao.DeleteStudent(studentIDToDelete);

                LoadAllStudents();
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
