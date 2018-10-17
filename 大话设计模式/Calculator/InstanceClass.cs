using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InstanceClass
    {
        private double num1=0;
        private double num2=0;

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
