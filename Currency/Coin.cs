using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    public class Coin : ICoin
    {
        public double MonetaryValue { get; private set; }
        public int Year { get; private set; }
        public string Name { get; private set; }

        public Coin()
        {
            MonetaryValue = 0.01f;
            Year = 2024;
            Name = "penny";
        }
        public string About()
        {
            return "$This is a {Name} worth {MonetaryValue} from {Year}";
        }
    }
}
