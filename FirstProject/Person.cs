using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Person
    {
        protected string name,address;
        protected long adddharno;
        public Person(string name, string address, long adddharno)
        {
            this.name = name;
            this.address = address;
            this.adddharno = adddharno;
        }

        public virtual string Display()
        {
            return $"{name} {address} {adddharno}";
        }
    }

    public class Patient : Person
    {
        private string bloodgroup, gender;
        private int fees;
        public Patient(string bloodgroup,string gender,int fees, string name, string address, long adddharno)
            :base(name,address,adddharno)
        {
            this.bloodgroup = bloodgroup;
            this.gender = gender;
            this.fees = fees;
        }

        public override string Display()
        {
            return $"{name} {address} {adddharno} {bloodgroup} {gender} {fees}";
        }
    }
}
