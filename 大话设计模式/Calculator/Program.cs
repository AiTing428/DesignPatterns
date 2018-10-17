using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InstanceClass operClass = null;
            
            
            //Console.WriteLine("请输入num1:");
            operClass.Num1 = 1;
            //Console.WriteLine("请输入num2:");
            operClass.Num2 = 2;
            Console.WriteLine("请输入符号：");
            string oper = Console.ReadLine();
            Operation.OperationClass(oper);
            double result = operClass.GetResult();
            Console.WriteLine("运算结果是：" + result);
            Console.Read();
        }
    }
}
