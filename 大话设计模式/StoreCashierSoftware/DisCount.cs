using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreCashierSoftware
{
    class CashFactory
    {
        public static CashSuper creatCashAccept(string type)
        {
            CashSuper cs = null;
            switch (type)
            {
                case "正常价":
                    cs = new OriginalPrice();
                    break;
                case "打八折":
                    cs = new DiscountPrice("0.8");
                    break;
                default:
                    break;
            }
            return cs;
        }
    }

    public abstract class CashSuper
    {
        public abstract double CurPrice(double originalPrice); //返回当前的价格，参数为原价
    }

    /// <summary>
    /// 原价
    /// </summary>
    class OriginalPrice : CashSuper
    {
        public override double CurPrice(double originalPrice)
        {
            return originalPrice;
        }
    }

    /// <summary>
    /// 折扣价
    /// </summary>
    class DiscountPrice : CashSuper
    {
        private double discount = 1;
        public DiscountPrice(string discount)
        {
            this.discount = double.Parse(discount);

        }

        public override double CurPrice(double originalPrice)
        {
            return originalPrice * discount;
        }
    }
}
