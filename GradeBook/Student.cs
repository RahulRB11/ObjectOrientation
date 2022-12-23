using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Student
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        int _rollno;
        public int Rollno
        {
            get { return _rollno; }
            set { _rollno = value; }
        }

        DateTime _dob;
        public DateTime Dob
        {
            get { return _dob; }
            set { _dob = value; }
        }
        
        int _class;
        public int Class1
        {
            get { return _class; }
            set { _class = value; }
        }

        public override string ToString()
        {
            return "\n\tName: " + this.Name + "\n\tRoll Number: " + this.Rollno + "\n\tClass: " + this.Class1 + "\n\tDate of Birth: " + this.Dob;
        }
    }
}
