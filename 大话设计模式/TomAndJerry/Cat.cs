using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomAndJerry
{
    class Cat
    {
        private string name;
        public Cat(string Name)
        {
            name = Name;
        }

        //public delegate void CatShoutEventHandler();        // 声明委托 无参数，无返回值

        // 此时委托有两个参数
        public delegate void CatShoutEventHandler(object sender, CatShoutEventArgs args);
        public event CatShoutEventHandler CatShout;         // 声明事件，并且时间类型是委托CatShoutEventHandler

        public void Shout()
        {
            Console.WriteLine("喵，我是{0}。", name);
            if (CatShout != null)
            {
                //表明当执行Shout()方法时，如果CatShout中有对象登记事件，则执行CaShout()（无参数时，）
                //CatShout();

                CatShoutEventArgs e = new CatShoutEventArgs();      //声明并实例化一个CatShoutEventArgs并给Name属性赋值为猫的名字
                e.Name = this.name;
                // 当事件触发时。通过所有等级的对象，并将发动同事的自己以及需要的数据传递进去
                CatShout(this, e);


            }
        }
    }
}
