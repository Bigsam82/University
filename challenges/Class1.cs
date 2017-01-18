using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges
{
    class Student
    {
        private string studentFullname;
        private string course;
        private string subject;
        private string university;
        private string email;
        private string phoneNumber;
        
        public Student()
        {

        }
        public Student(string studentFullname, string course, string subject, string university, string email, string phoneNumber)
        {
            this.studentFullname = studentFullname;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

       

     
        public void ShowyoInfo()
        {
            Console.WriteLine("Students name is: " + " " + studentFullname);
            Console.WriteLine("The students email address is: " + " " + email);
            Console.WriteLine("The students phone number is: " + "" + phoneNumber);
        }

        public string StudentFullname
        {
            get { return this.studentFullname; }
            set { this.studentFullname = value; }

        }


    }

}