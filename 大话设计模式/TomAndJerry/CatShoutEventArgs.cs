using System;

/*=============================知识点===================================
 * 
 * ✿✿ EventArgs
 *      即包含事件数据的类的基类。（换句话说，这个类的作用就是用来在事件触发时传递数据用的）
 *   
 * 
 * 
 =====================================================================*/


namespace TomAndJerry
{
    class CatShoutEventArgs : EventArgs
    {
        //属性Name表示的就是CatShout事件触发时，需要传递Cat对象的名字（因为此，也要修改Cat类的代码）
        private string name;
        public string Name { get { return name; } set { name = value; } }
    }
}
