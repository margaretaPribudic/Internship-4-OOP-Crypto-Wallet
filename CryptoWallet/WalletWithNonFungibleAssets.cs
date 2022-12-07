using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    public abstract class WalletWithNonFungibleAssets:Wallet
    {
        public List<Guid> AddressesOfNonFungibleAssets { get; set; }
        public List<Guid> AddressesOfAssets { get; set; }
        public WalletWithNonFungibleAssets() : base( ) { }

        public double GetTotalValueOfAllAssets(List<FungibleAsset> fungibleAssets, List<NonFungibleAsset> nonFungibleAssets)
        {
            double totalValue = 0;
            foreach (var item in BalanceOfFungibleAsset)
            {
                foreach (var fungibleAsset in fungibleAssets)
                {
                    if (item.Key == fungibleAsset.Address)
                    {
                        var valueOfAsset = fungibleAsset.ValueOfOneInUSD * item.Value;
                        totalValue += valueOfAsset;
                    }
                }
            }
            foreach (var item in AddressesOfNonFungibleAssets)
            {
                foreach (var nonFungAsset in nonFungibleAssets)
                {
                    double valueOfAsset;
                    if (item == nonFungAsset.Address)
                    {
                        foreach (var fungAsset in fungibleAssets)
                        {
                            if (nonFungAsset.AddressOfFungibleAsset == fungAsset.Address)
                            {
                                valueOfAsset = fungAsset.ValueOfOneInUSD;
                                totalValue += nonFungAsset.Value * valueOfAsset;
                            }
                        }
                    }
                }
            }
            return totalValue;
        }

        public void GetAsset(List<FungibleAsset> listOfFungibleAssets, List<NonFungibleAsset> nonFungibleAssets)
        {
            foreach (var item in BalanceOfFungibleAsset)
            {
                foreach (var asset in listOfFungibleAssets)
                {
                    if (item.Key == asset.Address)
                    {
                        Console.WriteLine($"Adresa: {asset.Address}\nIme asseta: {asset.Name}\nOznaka asseta: {asset.Label}\n" +
                            $"Ukupna vrijednost: {asset.ValueOfOneInUSD * item.Value}USD");
                    }
                }
            }
            foreach (var address in AddressesOfNonFungibleAssets)
            {
                foreach (var asset1 in nonFungibleAssets)
                {
                    if (address==asset1.Address)
                    {

                        double valueOfAsset;
                        foreach (var fungAsset1 in listOfFungibleAssets)
                        {
                            if (asset1.AddressOfFungibleAsset == fungAsset1.Address)
                            {
                                valueOfAsset = fungAsset1.ValueOfOneInUSD*asset1.Value;
                                Console.WriteLine($"Adresa: {asset1.Address}\nIme asseta: {asset1.Name}\n" +
                                    $"Vrijednost u fungible assetu: {asset1.Value}\n" +
                                    $"Ukupna vrijednost: {valueOfAsset}USD");
                            }
                        }
                        
                    }
                }
            }

        }

    }
}
