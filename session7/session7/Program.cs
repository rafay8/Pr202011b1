using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session7
{
    class Program
    {
        static void Main(string[] args)
        {
            students objStudent = new students();
            Grade objGrade = new Grade();
            objStudent.PrintDetails();
            objGrade.PrintDetails();
}
        class students
        {
            string _studentName = "James";
            string _address = "California";
            public virtual void PrintDetails()
            {
                Console.WriteLine("Student Name:" + _studentName);
                Console.WriteLine("Address:" + _address); 
            }
        }
        class Grade : students
        {
            string _class = "Four";
            float _percent = 71.25F;
            public override void PrintDetails()
            {
                Console.WriteLine("Class:" + _class);
                Console.WriteLine("Percentage:" + _percent);
            }



        }
    }
}
