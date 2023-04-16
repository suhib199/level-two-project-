using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace level_two_project_
{
        internal delegate void t();
        internal class Students
        {
            internal string studentName;
            internal int studentNumber;
            internal List<Courses> courseFullDetails;
            internal Students(string name, int number)
            {
                this.studentName = name;
                this.studentNumber = number;
                this.courseFullDetails = new List<Courses>();
            }
            internal void StudentInformations()//To call using delegate and depending on student number(in the notpad file)
            {

                Console.WriteLine("Student name: " + studentName);
                Console.WriteLine("Students number: " + studentNumber);
                Console.WriteLine("Courses and marks:");

                foreach (Courses pointer in courseFullDetails)
                {
                    Console.WriteLine(pointer.courseName.TrimEnd () + "|" + pointer.studentMark);
                    Console.WriteLine("Breif description about the course: " + pointer.breifDescriptions);
                }
           
            
            }
        }
    }

