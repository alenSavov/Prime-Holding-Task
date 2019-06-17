using Store.BusinessLogic;
using System.Linq;
using System;
using System.Text;
using Store;

namespace MarketStoreSystem
{
    public class StartUp
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Please, make a new card." + Environment.NewLine);
            sb.Append("  Example inputs:" + Environment.NewLine);
            sb.Append($"RegisterCard {CardConstants.BronzeCardName} 1" + Environment.NewLine);
            sb.Append($"RegisterCard {CardConstants.SilverCardName} 2" + Environment.NewLine);
            sb.Append($"RegisterCard {CardConstants.GoldCardName} 3" + Environment.NewLine);

            Console.WriteLine(sb);

            string input;
            var draftManager = new DraftManager();
            while ((input = Console.ReadLine()) != "Shutdown")
            {
                var arguments = input.Split().ToList();
                var command = arguments[0];
                arguments = arguments.Skip(1).ToList();

                switch (command)
                {
                    case "RegisterCard":
                        Console.WriteLine(draftManager.RegisterCard(arguments));
                        break;

                    case "MakePurchase":
                        Console.WriteLine(draftManager.MakePurchase(arguments));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(draftManager.ShutDown());
        }
    }
}
