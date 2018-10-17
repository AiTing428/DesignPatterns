using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGames
{
    /// <summary>
    /// 机器猫（哆啦A梦）
    /// </summary>
    class Doraemon : Cat, IChange
    {

        public Doraemon() : base() { }
        public Doraemon(string Name) : base(Name) { }

        public string ChangeThing(string thing)
        {
            return base.Shout() + "我有万能口袋，我可变出：" + thing;
        }
    }
}
