﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUpContest
{
    /// <summary>
    /// 客户端
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("张三");
            Console.WriteLine("\n第一种装扮：");
            TShirt shirt = new TShirt();
            BigTrouser bigTrouser = new BigTrouser();

            shirt.DressUp(p);
            bigTrouser.DressUp(shirt);
            bigTrouser.Show();

            Console.Read();
        }
    }

    #region 第二版（装饰模式）
    class Person
    {
        public Person() { }

        private string name;
        public Person(string Name)
        {
            this.name = Name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}", name);
        }
    }

    /// <summary>
    /// 抽象类
    /// </summary>
    abstract class Finery : Person
    {
        protected Person person;

        //打扮
        public void DressUp(Person p)
        {
            this.person = p;
        }

        public override void Show()
        {
            if (person != null)
            {
                person.Show();
            }

        }
    }

    class TShirt : Finery
    {
        public override void Show()
        {
            Console.WriteLine("大T恤");
            base.Show();
        }
    }

    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.WriteLine("垮裤");
            base.Show();
        }
    }

    class GymShoes : Finery
    {
        public override void Show()
        {
            Console.WriteLine("球鞋");
            base.Show();
        }
    }

    #endregion

    #region 第一版
    //客户端:
    //Person person1 = new Person("张三");
    //Console.WriteLine("\n第一种装扮：");
    //Finery finery1 = new TShirt();
    //Finery finery11 = new BigTrouser();

    //finery1.Show();
    //finery11.Show();
    //person1.Show();

    //Person person2 = new Person("李四");
    //Console.WriteLine("\n第二种装扮：");
    //Finery finery2 = new GymShoes();
    //Finery finery22 = new TShirt();

    //finery2.Show();
    //finery22.Show();
    //person2.Show();

    //Console.Read();


    //class Person
    //{
    //    private string name;
    //    public Person(string Name)
    //    {
    //        this.name = Name;
    //    }

    //    public void Show()
    //    {
    //        Console.WriteLine("装扮的{0}", name);
    //    }
    //}

    ///// <summary>
    ///// 抽象类
    ///// </summary>
    //abstract class Finery
    //{
    //    public abstract void Show();
    //}

    //class TShirt : Finery
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("大T恤");
    //    }
    //}

    //class BigTrouser : Finery
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("垮裤");
    //    }
    //}

    //class GymShoes : Finery
    //{
    //    public override void Show()
    //    {
    //        Console.WriteLine("球鞋");
    //    }
    //}
    #endregion

}
