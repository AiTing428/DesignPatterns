using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGames
{
    class Cattle:Animal
    {
        #region 私有变量
       
        #endregion

        #region 私有方法

        //====================方法重载=========================
        public Cattle() : base() { }

        public Cattle(string Name) : base(Name) { }
        //====================================================


        #endregion

        #region 公有方法
        protected override string GetShoutSound()
        {
            return "哞";
        }
        #endregion
    }
}
