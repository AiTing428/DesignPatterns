using System;

namespace Calputer
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeElements p_One = new ThreeElements();

            Console.WriteLine("请输入符号");
            string oper = Console.ReadLine();
            p_One = OperationMethod.Operation(oper);

            Console.WriteLine("请输入第一个数：");
            p_One.NumOne = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数");
            p_One.NumTwo = double.Parse(Console.ReadLine());

            double result = p_One.result();

            Console.WriteLine("结果是：" + result);
            Console.Read();
        }
    }

    /// <summary>
    /// 三个重要元素num1 num2 结果
    /// </summary>
    class ThreeElements
    {
        private double numOne;
        public double NumOne
        {
            get { return numOne; }
            set { numOne = value; }
        }

        private double numTwo;
        public double NumTwo
        {
            get { return numTwo; }
            set { numTwo = value; }
        }

        public virtual double result()
        {
            double result = 0;
            return result;
        }
    }

    /// <summary>
    ///对比传入的符号进行运行
    /// </summary>
    class OperationMethod
    {
        public static ThreeElements Operation(string oper)
        {
            ThreeElements op = null;

            switch (oper)
            {
                case "+":
                    op = new AddMethod();
                    break;
                case "-":
                    op = new SubMethod();
                    break;
                case "*":
                    op = new MulMethod();
                    break;
                case "/":
                    op = new DivMethod();
                    break;

            }

            return op;
        }
    }

    #region 加减乘除四个方法
    class AddMethod : ThreeElements
    {
        public override double result()
        {
            double result = 0;
            result = NumOne + NumTwo;
            return result;
        }
    }

    class SubMethod : ThreeElements
    {
        public override double result()
        {
            double result = 0;
            result = NumOne - NumTwo;
            return result;
        }
    }
    class MulMethod : ThreeElements
    {
        public override double result()
        {
            double result = 0;
            result = NumOne * NumTwo;
            return result;
        }
    }
    class DivMethod : ThreeElements
    {
        public override double result()
        {
            double result = 0;
            if (NumTwo != 0)
                result = NumOne / NumTwo;
            else
                Console.WriteLine("除数不能为0");
            return result;
        }
    }
    #endregion


}
