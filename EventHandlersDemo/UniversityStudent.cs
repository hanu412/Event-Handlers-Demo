using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlersDemo
{
    class UniversityStudent
    {

        public UniversityStudent()
        {
            this.DisplayTotalMarks+=UniversityStudent_DisplayTotalMarks;
        }

        void UniversityStudent_DisplayTotalMarks( string name, int marks)
        {
            Console.WriteLine("{0} has scored {1}", name, marks);
        }

        private int totalMarks =0;

        public string Name { get; set; }
        public int TotalMarks {
           set
           {
               totalMarks = value;

                DisplayTotalMarks(this.Name, totalMarks);
            }
        }

        public event DisplayTotalMarks DisplayTotalMarks;

        
    }

    class CollegeStudent : UniversityStudent
    {

        public CollegeStudent( )
        {
            //Use this if you want to have a custom implementation of the same event
           // this.DisplayTotalMarks+=CollegeStudent_DisplayTotalMarks;
        }

        //UnComment this if you would love to have a custom implementation.

        //void CollegeStudent_DisplayTotalMarks( string name, int totalMarks )
        //{
        //    Console.WriteLine("In the College Student Event Handler");
            
        //}
    }
}
