using System.Collections.Generic;
using MarketStoreSystem.Cards;
using System;

namespace Store.CardFactories
{
    public class CardFactory
    {
        public BaseCard CreateCard(List<string> arguments)
        {
            var type = arguments[0];
            var id = int.Parse(arguments[1]);
            
            switch (type)
            {
                case "Bronze":
                    return new BronzeCard(id);
                case "Silver":
                    return new SilverCard(id);
                case "Gold":
                    return new GoldCard(id);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
