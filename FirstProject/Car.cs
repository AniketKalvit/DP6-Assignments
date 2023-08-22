using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Car
    {
        private string companyname,modelname;
        private int cost;
                                              // default parameter
        public Car(string modelname, int cost, string companyname = "hundai")
        {
            this.modelname = modelname;
            this.cost = cost;
            this.companyname = companyname;
        }

        public string Print()
        {
            return $"{companyname}, {modelname}, {cost}";
        }
    }
}
