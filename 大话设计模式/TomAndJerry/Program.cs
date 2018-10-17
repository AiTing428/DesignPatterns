using System;

/*=============================知识点===================================
 * ✿✿ 委托与事件
 *      委托是对函数的封装，可以当作给方法的特征指定一个名称。关键字为：Delegate 
 * ！！ 委托是一种引用方法的类型，以当为委托分配了方法，委托将与该方法具有完全相同的行为。
 *      事件则是委托的一种特殊形式，当发生有意义的事情时，事件对象处理通知过程。 关键字为:event
 *      事件是说在发生其他类或对象关注的事情时，类或对象可通过时间通知它们
 * 
 * 
 =====================================================================*/

namespace TomAndJerry
{
    class Program
    {
        static void Main(string[] args)
        { 
            //实例化老猫Tom以及小老鼠Jerry和Jack
            Cat cat = new Cat("Tom");
            Mouse mouse_One = new Mouse("Jerry");
            Mouse mouse_Two = new Mouse("Jack");

            //表示将Mouse的Run方法通过实例化委托 Cat.CatShoutEventHandler登记到Cat的事件CatShout当中。
            cat.CatShout += new Cat.CatShoutEventHandler(mouse_One.Run);
            cat.CatShout += new Cat.CatShoutEventHandler(mouse_Two.Run);

            cat.Shout();
              
            Console.Read();
        }
    }
}
