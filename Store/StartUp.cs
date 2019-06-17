using Store.BusinessLogic;
using System.Linq;
using System;

namespace MarketStoreSystem
{
    public class StartUp
    {
        public static void Main()
        {
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
                       draftManager.MakePurchase(arguments);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(draftManager.ShutDown());
        }
    }
}
