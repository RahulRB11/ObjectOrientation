using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Getinfo

            Student info = new Student();
            //Console.WriteLine("\nEnter your name: ");
            info.Name = "Rahul";
            //Console.WriteLine("\nEnter your roll no: ");
            info.Rollno = 765;
            //Console.WriteLine("\nEnter you standard: ");
            info.Class1 = 5;
            //Console.WriteLine("\nEnter your date of birth: ");
            DateTime d = new DateTime(2004, 01, 11);
            info.Dob = d;
            Console.WriteLine("\n\t\tE-GRADE BOOK");
            Console.WriteLine("\t\t------------");
            Console.WriteLine(info);
            
            #endregion

            Subject[] subs = new Subject[4];
            Subject sub1 = new Subject();
            sub1.Subname = "Python";
            sub1.Mark = 97.5f;
            Subject sub2 = new Subject();
            sub2.Subname = "Dbms";
            sub2.Mark = 89;
            Subject sub3 = new Subject();
            sub3.Subname = "Electronics";
            sub3.Mark = 73.5f;
            Subject sub4 = new Subject();
            sub4.Subname = "DBS";
            sub4.Mark = 95;
            subs[0] = sub1;
            subs[1] = sub2;
            subs[2] = sub3;
            subs[3] = sub4;
            Subject t = new Subject();
            float total = t.MrkTotal(sub1.Mark, sub2.Mark, sub3.Mark, sub4.Mark);
            float average = t.MrkAverage(sub1.Mark, sub2.Mark, sub3.Mark, sub4.Mark);
            for (int i = 0; i < subs.Length; i++)
            {
                Console.WriteLine(subs[i]);
            }
            Console.WriteLine("\n\tTotal Marks: " + total + "\n\n\tAverage of Marks: " + average + "\n");
        }
    }
}
