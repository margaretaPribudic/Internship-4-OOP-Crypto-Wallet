using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    public class BitcoinWallet:Wallet
    {
        public BitcoinWallet() : base() { }

        public double GetTotalValueOfAllAssets(List<FungibleAsset> listOfFungibleAssets)
        {
            double totalValue = 0;
            foreach (var item in this.BalanceOfFungibleAsset)
            {
                foreach (var fungibleAsset in listOfFungibleAssets)
                {
                    if (item.Key == fungibleAsset.Address)
                    {
                        var valueOfAsset = fungibleAsset.ValueOfOneInUSD * item.Value;
                        totalValue += valueOfAsset;
                    }
                }
            }
            return totalValue;
        }
    }
}
