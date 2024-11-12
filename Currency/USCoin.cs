using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    enum USCoinMintMark { P, D, S, W }
    public class USCoin : Coin
    {
        USCoinMintMark MintMark;

        public string About()
        {
            return "about";
        }
    }
}
