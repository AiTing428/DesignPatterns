using System;


/*===============================✿知识点记录✿===================================
 * ✿✿ Virtual（虚方法）:
 * 
 * 
 * 
 * 
 * ✿✿ abstract(抽象类):
 *      1、抽象类不能被继承
 *      2、抽象方法是必须被子类重写的方法
 *      3、如果类中包含抽象方法，那么类就必须定义为抽象类，不论是否还包含其他一般方法
 *      
 *      
 *      
 *      
 * ✿✿ interface(接口)：
 *      接口是把隐式公共方法和属性组合起来，以封装特定功能的一个集合，一旦类实现了接口，类就可以支持接口所指定的所有属性和成员。声明接口在语法上与声明抽象类完全相同，但不允许提供接口中任何成员的执行方式。
 *      （！！！！所以接口不能实例化
 *                      不能有构造方法和字段
 *                      不能有修饰符
 *                      不能声明虚拟的或者静态的。
 *               还有实现接口的类就必须实现接口中的所有方法和属性）
 *     一个类可以支持多个接口，多个类也可以支持相同的接口。接口的命名前面要加大写字母“I”
 *        
 *        
 * ✿✿ abstract和interface的区别    
 *       1、从形态上讲：抽象类可以给一些成员的实现，接口却不包含成员的实现，抽象类的抽象成员可以被子类部分实现，接口的成员需要完全的实现。一个类只能继承一个抽象类，但可以继承多个接口
 *     !!2、类是对对象的抽象 ：
 *          抽象类是对类的抽象 ：（对类的整体即：字段，属性，方法）
 *          接口是对类的局部的抽象 ：（行为）
 *       3、如果行为跨越不停类的对象，可使用接口，对于一些相似的类对象，用继承抽象类。
 *       4、从设计角度上：抽象类是从子类中发现了公共的东西，泛化出父类，然后子类继承父类，而接口是根本不知子类的存在，方法如何实现还不确定，预先定义。
 * 
 * 
 * 
 ===============================================================================*/


namespace AnimalGames
{
    /// <summary>
    /// 因为Animal实例化没有任何意义所以改为 abstract（ab不能new）
    /// </summary>
    abstract class Animal
    {

        #region 变量
        protected string name = "";
        protected int shoutNum = 3;
        private string result = "";
        #endregion

        #region 构造函数
        public Animal()
        {
            name = "无名";
        }
        public Animal(string Name)
        {
            name = Name;
        }
        #endregion



        public int ShoutNum { get { return shoutNum; } set { shoutNum = value; } }

        public String Shout()
        {
            for (int i = 0; i < shoutNum; i++)

                result += GetShoutSound() + ",";
            return "我的名字叫" + name + "," + result;
        }

        //protected virtual string GetShoutSound()
        //{
        //    return "";
        //}
        /// 因为Animal中的 GetShoutSound()没有任何意义所以可以改为 abstract(抽象类):抽象类没有方法体
        protected abstract string GetShoutSound();



    }
    interface IChange
    {
        string ChangeThing(string thing);
    }
}
