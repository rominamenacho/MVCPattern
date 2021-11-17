using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
   public class Student
    {
        private string rollNo;
        private string name;

        public Student(string _rollNo, string _name)
        {
            this.RollNo = _rollNo;
            this.Name = _name;
        }

        public string RollNo { get => rollNo; set => rollNo = value; }
        public string Name { get => name; set => name = value; }
    }
}
