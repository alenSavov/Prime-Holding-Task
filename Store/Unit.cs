namespace Store
{
    public abstract class Unit
    {
        public int Id { get; set; }

        public abstract string Type { get; set; }

        protected Unit(int Id)
        {
            this.Id = Id;
        }
    }
}
