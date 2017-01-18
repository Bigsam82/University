using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges
{
    class Student
    {
        private string studentFullname;//field
        private string course;
        private string subject;
        private string university;
        private string email;
        private string phoneNumber;
        
        public Student()//method
        {

        }
        public Student(string studentFullname, string course, string subject, string university, string email, string phoneNumber)//constructor
        {
            this.studentFullname = studentFullname;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

       

     
        public void ShowyoInfo()//method
        {
            Console.WriteLine("Students name is: " + " " + studentFullname);
            Console.WriteLine("The students email address is: " + " " + email);
            Console.WriteLine("The students phone number is: " + "" + phoneNumber);
            Console.WriteLine("The students university is: " + " " + university);
        }

        public string StudentFullname//properties
        {
            get { return this.studentFullname; }
            set { this.studentFullname = value; }

        }
        public string University//properties
        {
            get { return this.university; }
            set { this.university = value; }
                    
        }

    }

}