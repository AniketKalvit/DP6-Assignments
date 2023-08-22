using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Date
    {
        //members of a class

        //declaraion of data members
        private int day,year; // 4+4
        private string month;// 3 bytes

        // Method --> this method assign value to each data member
        // method definition
        public void AcceptDate(int dd,string mm,int yy) // dd,mm,yy can be accessible in the method
        {
            day = dd;
            month = mm;
            year = yy;
        }

        // Method --> return the data from each data member
        public string PrintDate()
        {
            return $"Date : {day} / {month} / {year}";
        }

    }
}
