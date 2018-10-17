using System;

namespace AnimalGames
{
    class Cat:Animal
    {

        #region 私有变量
        private string result = "";     //最终猫叫的次数
        #endregion

        #region 私有方法

        //====================方法重载=========================
        public Cat() : base() { }

        public Cat(string Name) : base(Name) { }
        //====================================================
        #endregion

        #region 公有方法
        protected override string GetShoutSound()
        {
            return "喵";
        }
        #endregion

    }
}
