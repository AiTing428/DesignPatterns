using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式_销售系统
{
    /// <summary>
    /// 父类：获取当前原价
    /// </summary>
    abstract class CurPrice
    {
        public abstract double Curprice(double money);
    }

    class OriginalPrice : CurPrice
    {
        public override double Curprice(double money)
        {
            return money;
        }
    }
    class DiscountPrice : CurPrice
    {
        public 

        public override double Curprice(double money)
        {
            
        }
    }
}
