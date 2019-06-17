using System;

namespace MarketStoreSystem
{
    public static class PayDesk
    {
        public static void PrintAccountInfo(string cardType, decimal turnover,
            decimal currentPurchaseSum, double discountRate, decimal discount, decimal total)
        {
            Console.WriteLine();
            Console.WriteLine($"{cardType}:");
           
            Console.WriteLine($"Purchase value:${currentPurchaseSum.ToString("F2")}");
            Console.WriteLine($"Discount rate: {discountRate.ToString("F1")}%");
            Console.WriteLine($"Discount: ${discount.ToString("F2")}");
            Console.WriteLine($"Total: ${total.ToString("F2")}");
            Console.WriteLine("Add new command or write: Shutdown to close the system");
            Console.WriteLine();

        }
    }
}
