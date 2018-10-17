using System;

namespace TomAndJerry
{
    class Mouse
    {
        private string name;
        public Mouse(string Name)
        {
            name = Name;
        }

        ///// <summary>
        ///// 跑的方法
        ///// </summary>
        //public void Run()
        //{
        //    Console.WriteLine("老猫来了，{0}快跑！！！",name);
        //}



        public void Run(object Semde, CatShoutEventArgs args)
        {
            Console.WriteLine("老猫{0}来了，{1}快跑！！！", args.Name, name); ;
        }
    }
}
