using Store;

namespace MarketStoreSystem.Cards
{
    public class SilverCard : BaseCard
    {
        public override string Type { get; set; }    // Type Card -> Silver

        protected override double DiscountRate { get; set; }

        protected override decimal TurnoverPreviousMonth { get; set; }


        public SilverCard(int Id)
            : base(Id)
        {
            this.Type = CardConstants.SilverCardName;
            this.DiscountRate = 2;
        }


        public override double GetDiscountPercent(decimal turnover)
        {
            if (turnover > 300)
            {
                DiscountRate = 3.5;
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
