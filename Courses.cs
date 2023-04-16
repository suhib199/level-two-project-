using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_two_project_
{
    internal class Courses
    {
        internal string courseName;
        internal double studentMark;
        internal string breifDescriptions;
        internal Courses(string courseName, double studentMark, string breifDescriptions)
        {
            this.courseName = courseName;
            this.studentMark = studentMark;
            this.breifDescriptions = breifDescriptions;
        }
    }
}
