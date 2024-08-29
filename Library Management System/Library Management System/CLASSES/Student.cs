using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.CLASSES
{
    public class Student
    {
        //public string Name { get; set; }
        //public string ID { get; set; }
        //public int Contact { get; set; }
        //public string Email { get; set; }

        private string name;
        private string id;
        private int contact;
        private string email;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //constructor class
        public Student(string sname, string sid, int sphone, string semail)
        {
            Name = sname;
            ID = sid;
            Contact = sphone;
            Email = semail;
        }
    }
}
