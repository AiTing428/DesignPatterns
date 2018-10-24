using System;


/*===============================================================================
 * 代理模式结构实例
 ==============================================================================*/


namespace Confessions
{
    /// <summary>
    /// 客户端（被追求者）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

           
            SchoolGirl girl = new SchoolGirl();
            girl.Name = "李狗儿";
            Agency daili = new Agency(girl);
            daili.GiveChoolate();
            Console.Read();
        }
    }

    /// <summary>
    /// 送礼物接口
    /// </summary>
    interface IGiveGift
    {
        void GiveFlowers();
        void GiveDolis();
        void GiveChoolate();
    }

    /// <summary>
    /// 被追求者
    /// </summary>
    class SchoolGirl
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    /// <summary>
    /// 追求者
    /// </summary>
    class Pursuer : IGiveGift
    {
        SchoolGirl girl;
        public Pursuer(SchoolGirl Girl)
        {
            girl = Girl;
        }

        public void GiveDolis()
        {
            Console.WriteLine(girl.Name + "送你洋娃娃！");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(girl.Name + "送你花！");
        }

        public void GiveChoolate()
        {
            Console.WriteLine(girl.Name + "送你巧克力！");
        }
    }

    /// <summary>
    /// 代理
    /// </summary>
    class Agency : IGiveGift
    {
        Pursuer boy;
        public Agency(SchoolGirl girl)
        {
            boy = new Pursuer(girl);
        }

        public void GiveDolis()
        {
            boy.GiveDolis();
        }

        public void GiveFlowers()
        {
            boy.GiveFlowers();
        }

        public void GiveChoolate()
        {

            boy.GiveChoolate();
        }
    }

}
