using System;
using System.Linq;
using MarketStoreSystem;
using Store.CardFactories;
using MarketStoreSystem.Cards;
using System.Collections.Generic;

namespace Store.BusinessLogic
{
    public class DraftManager
    {
        private List<BaseCard> cards;

        private CardFactory cardFactory;

        public DraftManager()
        {
            this.cards = new List<BaseCard>();
            this.cardFactory = new CardFactory();

        }

        public string RegisterCard(List<string> arguments)
        {
            try
            {
                int id = int.Parse(arguments[1]);
                if (IsExistCardWithSameId(id))
                {
                    return $"Card with id - {id}, already exist";
                }

                var card = cardFactory.CreateCard(arguments);
                cards.Add(card);

                return $"Successfully registered {card.Type} card with Id - {card.Id}";
            }
            catch (ArgumentException ex)
            {
                return ex.Message;
            }

        }

        public string MakePurchase(List<string> arguments)
        {
            if (cards.Count == 0)
            {
                return "You need to make a new card first.";
            }

            int cardId = int.Parse(arguments[0]);
            decimal currentPurchaseSum = decimal.Parse(arguments[1]);

            var card = GetCard(cardId);
            var discountRate = card.GetDiscountPercent(currentPurchaseSum);
            var resultSet = GetCalculateThePriceWithDiscount(currentPurchaseSum, discountRate);

            card.AddTurnover(currentPurchaseSum);

            PayDesk.PrintAccountInfo(card.Type, card.GetTurnover(), currentPurchaseSum, discountRate, resultSet[0], resultSet[1]);

            return "";
        }

        private List<decimal> GetCalculateThePriceWithDiscount(decimal purchaseSum, double discountRate)
        {
            decimal discount = purchaseSum * (decimal)(discountRate / 100);
            decimal total = purchaseSum - discount;

            var resultSet = new List<decimal>();


            resultSet.Add(discount);
            resultSet.Add(total);

            return resultSet;
        }

        private BaseCard GetCard(int id)
        {
            return cards.FirstOrDefault(c => c.Id == id);
        }

        private bool IsExistCardWithSameId(int id)
        {
            return cards.Any(c => c.Id == id);
        }

        public string ShutDown()
        {
            return $"The system is off";
        }
    }
}
