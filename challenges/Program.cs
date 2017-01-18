using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Robert Gates", "biology 101","Math", "OSU","ThatGates@gmail.com", "304-233-3838 ");

            student1.ShowyoInfo();

            student1.StudentFullname = " Gary";
            student1.University = "FAMU";
            student1.ShowyoInfo();
            
             


        }
    }
}
