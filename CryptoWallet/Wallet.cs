using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    public abstract class Wallet
    {
        public Guid Address { get; }
        public Dictionary<Guid, int> BalanceOfFungibleAsset { get; set; }
        public List<Guid> AdressesOfFungibleAssets { get; set; }
        public List<Guid> AdressesOfTransactions { get; set; }

        public Wallet()
        {
            Address = Guid.NewGuid();
        }
        public double GetTotalValueOfAllAssets(List<FungibleAsset> listOfFungibleAssets)
        {
            double totalValue = 0;
            foreach (var item in BalanceOfFungibleAsset)
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
        public void GetFungibleAsset(List<FungibleAsset> listOfFungibleAssets)
        {
            foreach (var item in BalanceOfFungibleAsset)
            {
                foreach (var asset in listOfFungibleAssets)
                {
                    if (item.Key == asset.Address)
                    {
                        Console.WriteLine($"Adresa: {asset.Address}\nIme asseta: {asset.Name}\nOznaka asseta: {asset.Label}\n" +
                            $"Ukupna vrijednost: {asset.ValueOfOneInUSD*item.Value}USD");
                    }
                }
            }
        }
    
    }
}
