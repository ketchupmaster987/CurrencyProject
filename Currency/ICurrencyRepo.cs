namespace Currency
{
    public interface ICurrencyRepo
    {
        public List<ICoin> Coins { get; }

        public string About()
        {
            return "about this repo";
        }

        public void AddCoin(ICoin c)
        {
            Coins.Add(c);
        }

        public int GetCoinCount()
        {
            return Coins.Count;
        }

        public ICurrencyRepo MakeChange(double Amount)
        {
            return this;
        }

        public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {
            return this;
        }

        public void RemoveCoin(ICoin c)
        {
            Coins.Remove(c);
        }

        public double TotalValue()
        {
            double total = 0;
            foreach(ICoin c in Coins)
            {
                total += c.MonetaryValue;
            }
            return total;
        }

    }
}