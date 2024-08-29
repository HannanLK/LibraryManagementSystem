using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.FORMS
{
    public partial class interfaceSelect : Form
    {
        public interfaceSelect()
        {
            InitializeComponent();
        }

        private void btn_gui_Click(object sender, EventArgs e)
        {
            //opens the login in GUI
            new Login_Form().Show();
            this.Hide();
        }

        private void btn_cli_Click(object sender, EventArgs e)
        {
            string path = "\"C:\\Users\\DELL\\Desktop\\APIIT\\1st Year\\Sem 2\\SDAM (mon)\\Assignment\\#SDAM\\Draft 6.3\\Library Management System\\CommandLine\\bin\\Debug\\net8.0\\CommandLine.exe\"";

            Process.Start(path);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
