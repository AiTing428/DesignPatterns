using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 一个公司会有很多工作种类，每个工作种类负责的工作不同，自然每个工种的工资计算方法也会有千差万别，我们今天就以工资的计算为例来说明策略模式的使用 (2018-10-17任务)

namespace 策略模式练习
{
    class Program
    {
        static void Main(string[] args)
        {

            Context context = new Context(new Engineer());
            context.Current();

            Context context1 = new Context(new FrontDesk());
            context1.Current();

            Console.Read();
        }
    }

    //发工资
    abstract class Payoff
    {
        public abstract void Paystub();
    }

    //工程师
    class Engineer : Payoff
    {
        public override void Paystub()
        {
            Console.WriteLine("工程师，实发9000元");
        }
    }
    //前台
    class FrontDesk : Payoff
    {
        public override void Paystub()
        {
            Console.WriteLine("前台，实发6000元");
        }
    }
    //项目经理
    class PM : Payoff
    {
        public override void Paystub()
        {
            Console.WriteLine("项目经理，实发15000元");
        }
    }


    class Context
    {

        Payoff payoff;
        public Context(Payoff p)
        {

            this.payoff = p;
        }

        public void Current() {
            payoff.Paystub();
        }
    }

}
