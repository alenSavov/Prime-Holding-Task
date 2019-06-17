using System;
using System.Text;

namespace MarketStoreSystem
{
    public static class PayDesk
    {
        public static void PrintAccountInfo(string cardType, decimal turnover,
            decimal currentPurchaseSum, double discountRate, decimal discount, decimal total)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{cardType}:" + Environment.NewLine);
            sb.Append($"   Purchase value:${currentPurchaseSum.ToString("F2")}" + Environment.NewLine);
            sb.Append($"   Discount rate: {discountRate.ToString("F1")}%" + Environment.NewLine);
            sb.Append($"   Discount: ${discount.ToString("F2")}" + Environment.NewLine);
            sb.Append($"   Total: ${total.ToString("F2")}" + Environment.NewLine);
            sb.Append("Add new command or write: Shutdown to close the system");

            Console.WriteLine(sb);
        }
    }
}
