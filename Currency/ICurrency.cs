namespace Currency
{
    public interface ICurrency
    {
        public double MonetaryValue { get; }
        public string Name { get; }

        public string About()
        {
            return "about this currency";
        }
    }
}