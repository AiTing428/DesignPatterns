using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 练习：背景给兔子涂上自己喜欢的颜色（）

namespace ColourRabbit
{
    /// <summary>
    /// 客户端
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit("张三");
            Console.WriteLine("\n第一位画家");
            Black black = new Black();
            Red red = new Red();

            black.Change(rabbit);
            red.Change(black);
            red.Show();


            Rabbit rabbit2 = new Rabbit("李四");
            Console.WriteLine("\n第二位画家");
            Blue blue = new Blue();
            Yellow yellow = new Yellow();

            blue.Change(rabbit2);
            yellow.Change(blue);
            yellow.Show();

            Console.Read();
        }
    }

    class Rabbit
    {
        string name;
        public Rabbit() { }
        public Rabbit(String Name)
        {
            this.name = Name;
        }

        public virtual void Show()
        {
            Console.WriteLine("{0}涂的兔子",name);
        }
    }


    abstract class Tintage : Rabbit
    {
        Rabbit Rabbit;

        //涂色
        public void Change(Rabbit r)
        {
            Rabbit = r;
        }

        public override void Show()
        {
            if (Rabbit != null)
            {
                Rabbit.Show();
            }
        }
    }

    class Black : Tintage
    {
        public override void Show()
        {
            Console.WriteLine("白色");
            base.Show();
        }
    }

    class Yellow : Tintage
    {
        public override void Show()
        {
            Console.WriteLine("黄色");
            base.Show();
        }
    }

    class Blue : Tintage
    {
        public override void Show()
        {
            Console.WriteLine("蓝色");
            base.Show();
        }
    }
    class Red : Tintage
    {
        public override void Show()
        {
            Console.WriteLine("红色");
            base.Show();
        }
    }
}
