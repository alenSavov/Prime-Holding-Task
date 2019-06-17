using Store;

namespace MarketStoreSystem.Cards
{
    public class BronzeCard : BaseCard
    {       
        public override string Type { get; set; }    // Type Card -> Bronse

        public BronzeCard(int Id) 
            : base(Id)
        {
            this.Type = CardConstants.BronzeCardName; 

            this.DiscountRate = 0;
            this.TurnoverPreviousMonth = 0;
            this.CurrentTurnover = 0;
        }

        protected override double DiscountRate { get; set; }
        
        protected override decimal TurnoverPreviousMonth { get; set; }

        protected override decimal CurrentTurnover { get; set; }

        public override double GetDiscountPercent(decimal turnover)
        {
            double percentDiscount = 0;

            if (this.TurnoverPreviousMonth < 100)
            {
                percentDiscount = 0;
            }
            else if (this.TurnoverPreviousMonth >= 100 && this.TurnoverPreviousMonth <= 300)
            {
                percentDiscount = 1;
            }
            else if (this.TurnoverPreviousMonth > 300)
            {
                percentDiscount = 2.5;
            }

            return percentDiscount;
        }

        public override void AddTurnover(decimal turnover)
        {
            this.TurnoverPreviousMonth += turnover;
        }

        public override decimal GetTurnover()
        {
            return this.TurnoverPreviousMonth;
        }
    }
}
