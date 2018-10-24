using System;


/*===============================================================================
 * 代理模式结构实例
 ==============================================================================*/


namespace ProxyPattern
{
    /// <summary>
    /// 客户端
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();

            Console.Read();
        }
    }

    /// <summary>
    /// 公共接口
    /// </summary>
    abstract class Subject
    {
        public abstract void Request();
    }

    /// <summary>
    /// 实体
    /// </summary>
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真实的请求!");
        }
    }

    /// <summary>
    /// 代理
    /// </summary>
    class Proxy : Subject
    {
        RealSubject realSubject;
        public override void Request()
        {
            if (realSubject==null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }

}
