using System;


/*===============================================================================
 * 装饰模式结构实例
 * 
 * 理解：利用SetCom来对对象进行包装，这样每个装饰对象的实现就和如何使用这个对象分离开了。每个装饰对象只关心自己的功能，不需要关系如何被添加到对象链当中。
 ==============================================================================*/

namespace DecoratorPattern
{
    /// <summary>
    /// 客户端
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent C = new ConcreteComponent();
            ConcreteDeconratorA deconratorA = new ConcreteDeconratorA();
            ConcreteDeconratorB deconratorB = new ConcreteDeconratorB();

            // 装饰的方法是：首先用ConcreteComponent实例化对象然后分别实例化deconratorA，deconratorB对象deconratorA来包装C，在用deconratorB来包装deconratorA，最终执行deconratorB的Operation。
            deconratorA.SetComponent(C);
            deconratorB.SetComponent(deconratorA);
            deconratorB.Operation();

            Console.Read();
        }
    }

    abstract class Component
    {

        public abstract void Operation();
    }

    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }

    abstract class Deconrator : Component
    {
        protected Component component;
        public void SetComponent(Component Com)
        {
            this.component = Com;
        }

        public override void Operation()    // 重写Operation(),实际执行的是Component.O..();
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    class ConcreteDeconratorA : Deconrator
    {
        private string addedState;              //该类的独有功能，以区别ConcreteDeconratorB

        public override void Operation()
        {
            base.Operation();                   //首先运行原Component.Oper,在执行addedState,相当于对原Component进行了修饰
            addedState = "new State";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }

    class ConcreteDeconratorB : Deconrator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具体装饰对象B的操作");
        }

        private void AddedBehavior()
        {

        }
    }
}
