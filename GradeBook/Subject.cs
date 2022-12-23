using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Subject
    {
        string _subname;
        public string Subname
        {
            get { return _subname; }
            set { _subname = value; }
        }

        float _mark;
        public float Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        //float _total;
        //public float Total
        //{
        //    get { return MrkTotal(); }
        //    //set { _total = value; }
        //}

        public float MrkTotal(float m1,float m2, float m3, float m4)
        {
            float temp = m1 + m2 + m3 + m4;
            return temp;
        }

        public float MrkAverage(float m1, float m2, float m3, float m4)
        {
            float avg = (m1 + m2 + m3 + m4) / 4;
            return avg;
        }

        public override string ToString()
        {
            return "\n\tSubject: " + this.Subname + "\n\tMark: " + this.Mark;
        }

        
         
    }
}
