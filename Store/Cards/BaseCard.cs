using Store;

namespace MarketStoreSystem.Cards
{
    public abstract class BaseCard : Unit
    {
        protected BaseCard(int Id) 
            : base(Id)
        {

        }
        
        protected virtual double DiscountRate { get; set; }

        protected virtual decimal TurnoverPreviousMonth { get; set; }

        protected virtual decimal CurrentTurnover { get; set; }

        public abstract double GetDiscountPercent(decimal turnover);

        public abstract void AddTurnover(decimal turnover);

        public abstract decimal GetTurnover();

    }
}
