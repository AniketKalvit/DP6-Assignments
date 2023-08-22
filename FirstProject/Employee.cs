using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    // base class or parent class
    public class Employee
    {
        // access within class & access in child class
        protected int id;//data member
        protected string name;
        protected double salary,hra,da,ta,pf,gross;
        private static int count;// default value - 0
        // constructor
        public Employee() // parameter less constructor
        {
            // assign default value
            id = 0;
            name = "";
            salary = 0.0;
        }
        public Employee(string name,double salary)//parametric constructor
        {
            count++;
            this.id = count;
            this.name = name;
            this.salary = salary;
        }
        
        public static int GetEmpCount()
        {
            return count;
        }
        public virtual void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + da + ta) - pf;
        }
        public virtual string Print()
        {
            return $"Employee salary Gross = {gross}";
        }
    }

    //manager is child class , Employee -base / parent class
    
    public class Manager : Employee
    {
        private double foodallownce;
        public Manager():base()
        {

        }
        public Manager(double foodallownce,string name,double salary):base(name,salary)
        {
            this.foodallownce = foodallownce;
        }

        // polymorphism- multiple class with same behaviour but implementation is diff
        // method overrding
        public override void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + da + ta + foodallownce) - pf;
        }

        public override string Print()
        {
            return $"manager's salary Gross={gross}";
        }


    }
}
