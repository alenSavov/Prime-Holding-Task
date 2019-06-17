using Store;
using System;

namespace MarketStoreSystem.Cards
{
    public class GoldCard : BaseCard
    {
        public override string Type { get; set; }    // Type Card -> Gold

        public GoldCard(int Id) 
            : base(Id)
        {
            this.Type = CardConstants.GoldCardName;
            this.DiscountRate = 2;
        }

        protected override double DiscountRate { get; set; }

        protected override decimal TurnoverPreviousMonth { get; set; }

        public override double GetDiscountPercent(decimal turnover)
        {
            const double maxDiscountPercent = 10;
            double currentDiscountPercent = DiscountRate;

            if (turnover < 100)
            {
                return DiscountRate;
            }

            int counter = (int)Math.Floor(turnover / 100);

            for (int i = 0; i < counter; i++)
            {
                if (DiscountRate == maxDiscountPercent)
                {
                    break;
                }

                DiscountRate++;
            }
            
            return DiscountRate;
        }

        public override void AddTurnover(decimal turnover)
        {
            this.TurnoverPreviousMonth += turnover;
        }

        public override decimal GetTurnover()
        {
            return this.CurrentTurnover;
        }
    }
}
