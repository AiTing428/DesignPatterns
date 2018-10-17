using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGames
{
    /// <summary>
    /// 孙悟空
    /// </summary>
    class SunWukong : Monkey, IChange
    {
        public SunWukong() : base() { }
        public SunWukong(string Name) : base(Name) { }

        public string ChangeThing(string thing)
        {
            return base.Shout() + "我会七十二变，我可变出：" + thing;
        }
    }
}
