using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 客户端
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStrategyA());
            context.ContextInterface();
          
        }
    }

    class Context {

        Strategy strategy; 

        public Context(Strategy s)
        {
            this.strategy = s;
        }

        public  void ContextInterface() {

            strategy.AlgorithmInterface();
        }
    }

    abstract class Strategy {
        public abstract void AlgorithmInterface();
    }

    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法AAA");
        }
    }

    class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法BBB");
        }
    }
}
