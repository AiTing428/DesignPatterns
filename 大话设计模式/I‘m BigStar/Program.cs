using System;

/*==============================================================================
 * 当成为大明星之后，就会请经济人了，很多事情都不要自己去做了。我们就以炒作为案例，使用代理模式来实现。
 =============================================================================*/

namespace I_m_BigStar
{
    /// <summary>
    /// 客户端
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Broker broker = new Broker();
            broker.Sensationalization("与某女网红现身某某夜店！！！！");
            Console.Read();
        }
    }

    abstract class Star
    {
        public virtual void Sensationalization(string thing)
        {
            Console.WriteLine(thing);
        }
    }

    class WanStar : Star
    {
        public WanStar() { }
        public override void Sensationalization(string thing)
        {
            Console.WriteLine(thing);
        }
    }

    class Broker:Star
    {
        private WanStar boss;

        public Broker()
        {
            boss = new WanStar();
        }

        public override void Sensationalization(string thing)
        {
            Console.WriteLine("【国民Wang，又交新女朋友了！！！】");
            base.Sensationalization(thing);
            Console.WriteLine("更博澄清！！！！");
        }
    }
}
