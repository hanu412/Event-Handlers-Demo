using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlersDemo
{
    public delegate void DisplayTotalMarks(string name, int totalMarks);

    class Program
    {
        static void Main( string[] args )
        {
            var stud = new UniversityStudent
            {
                Name = "John Doe",
                TotalMarks = 100
            };

            //Here we change the marks...so the event "TotalMarksHandler" gets fired again. 
           
            stud.TotalMarks = -99;

            var collegeStudent = new CollegeStudent
            {
                Name = "College Student",
                TotalMarks = -99 
              
            };

            //Here we change the marks of this college student guy...so the event "TotalMarksHandler" gets fired again. 
            collegeStudent.TotalMarks = 99;

            Console.ReadLine();
        }

       
       
    }
}
