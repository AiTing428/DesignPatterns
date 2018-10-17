using System;


namespace Understand
{
    /// <summary>
    /// 客户端
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Context cat = new Context(new CatIntroduce());
            cat.ContextInterface();

            Context dog = new Context(new DogIntroduce());
            dog.ContextInterface();

            Context monkey = new Context(new MonkeyIntroduce());
            monkey.ContextInterface();

            Context pig = new Context(new PigIntroduce());
            pig.ContextInterface();

            Console.Read();
        }
    }

    /// <summary>
    /// 抽象动物乐园类
    /// </summary>
    abstract class AnimalParadise
    {
        /// <summary>
        /// 自我介绍方法
        /// </summary>
        public abstract void IntroduceMyself();
    }

    #region 封装了具体的算法和行为，继承于AnimalParadise
    class CatIntroduce : AnimalParadise
    {
        public override void IntroduceMyself()
        {
            Console.WriteLine("大家好，我是加菲猫！");
        }
    }

    class DogIntroduce : AnimalParadise
    {
        public override void IntroduceMyself()
        {
            Console.WriteLine("大家好，我是哮天犬！");
        }
    }

    class MonkeyIntroduce : AnimalParadise
    {
        public override void IntroduceMyself()
        {
            Console.WriteLine("大家好，我是齐天大圣美猴王！");
        }
    }
    #endregion

    /// <summary>
    /// 这样写维护了一个对抽象方法对象的引用？？
    /// </summary>
    class Context
    {
        AnimalParadise animalParadise;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="AnimalParadise">外部传进来的动物</param>
        public Context(AnimalParadise AnimalParadise)
        {
            animalParadise = AnimalParadise;
        }

        /// <summary>
        /// 上下文接口
        /// </summary>
        public void ContextInterface()      // 更具具体的动物，调用其自我介绍的方法
        {
            animalParadise.IntroduceMyself();
        }
    }

    #region 新添加动物 (如果想新增动物参加自我介绍的话只需增加一个类即可，在客户端便能直接使用不用修改，实现了开放--封闭原则)
    class PigIntroduce : AnimalParadise
    {
        public override void IntroduceMyself()
        {
            Console.WriteLine("大家好，我是天蓬元帅猪八戒！");
        }
    }
    #endregion
}
