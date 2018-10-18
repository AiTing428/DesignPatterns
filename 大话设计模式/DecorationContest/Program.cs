using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//给房子装修（2018-10-18任务）

namespace DecorationContest
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House("张三");
            Bench bench = new Bench();
            Computer computer = new Computer();

            bench.Decoration(house);
            computer.Decoration(bench);
            computer.Show();



            House lisih = new House("李四");
            Bed bed = new Bed();
            Table table = new Table();
            bed.Decoration(lisih);
            table.Decoration(bed);
            table.Show();

            Console.Read();
        }
    }

    class House
    {
        string name;
        public House() { }
        public House(string Name)
        {
            this.name = Name;
        }

        public virtual void Show()
        {
            Console.WriteLine("{0}装修的房子", name);
        }
    }

    abstract class AddObject : House
    {
        House house;

        //装修
        public void Decoration(House h)
        {
            this.house = h;
        }

        public override void Show()
        {
            if (house != null)
            {
                house.Show();
            }
        }
    }

    class Table : AddObject
    {
        public override void Show()
        {
            Console.WriteLine("桌子");
            base.Show();
        }
    }

    class Bed : AddObject
    {
        public override void Show()
        {
            Console.WriteLine("床");
            base.Show();
        }
    }

    class Computer : AddObject
    {
        public override void Show()
        {
            Console.WriteLine("电脑");
            base.Show();
        }
    }


    class Bench : AddObject
    {
        public override void Show()
        {
            Console.WriteLine("长凳");
            base.Show();
        }
    }
}
