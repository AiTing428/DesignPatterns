using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGames
{
    class Dog : Animal
    {
        #region 私有变量
        private string result = "";     //最终狗叫的次数
        #endregion

        #region 私有方法

        //====================方法重载=========================
        public Dog() : base() { }

        public Dog(string Name) : base(Name) { }
        //====================================================


        #endregion

        #region 公有方法
        protected override string GetShoutSound()
        {
            return "旺";
        }
        #endregion

    }
}
