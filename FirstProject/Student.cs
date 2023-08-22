using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Student
    {
        private int rollno;
        private string name;
        // 1. assign the value using ctor

        public Student(int rollno,string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        
        //2. assign the value using properties

        public int RollNo
        {
            set { rollno = value; }
            get { return rollno; }  
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        //3. create auto implemented properties

        public int Rollno { get; set; }
        public string StudentName { get; set; }
    }
}
