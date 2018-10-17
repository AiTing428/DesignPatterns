using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// 运算
    /// </summary>
    public class Operation
    {
        public static InstanceClass OperationClass(string Oper)
        {
            InstanceClass oper = null;
            switch (Oper)
            {
                case "+":
                    oper=new AddClass();
                    break;
                case "-":
                    oper=new SubtractClass();
                    break;
                case "*":
                    oper=new MultiplyClass();
                    break;
                case "/":
                    oper =new Division();
                    break;
            }

            return oper;
        }
    }

    /// <summary>
    /// 加法
    /// </summary>
    public class AddClass:InstanceClass
    {
        public override double GetResult()
        {
            double result = 0;
            result = Num1 + Num2;
            return result;
        }
    }

    /// <summary>
    /// 减法
    /// </summary>
    public class SubtractClass:InstanceClass
    {
        public override double GetResult()
        {
            double result = 0;
            result = Num1 - Num2;
            return result;
        }
    }

    /// <summary>
    /// 乘法
    /// </summary>
    public class MultiplyClass:InstanceClass
    {
        public override double GetResult()
        {
            double result = 0;
            result = Num1*Num2;
            return result;
        }
    }

   /// <summary>
   /// 除法
   /// </summary>
    public class Division:InstanceClass
    {
       public override double GetResult()
       {
            double result = 0;
           result = Num1/Num2;
            return result;
        }
    }
}
