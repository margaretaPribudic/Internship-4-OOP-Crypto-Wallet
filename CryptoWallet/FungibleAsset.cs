using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    public class FungibleAsset
    {
        public Guid Address { get; }
        public string Name { get; set; }
        public string Label { get; set; }
        public double ValueOfOneInUSD { get; private set; }

        public FungibleAsset( string name, string label,double valueOfOneInUSD)
        {
            Address= new Guid();
            Name = name;
            Label = label;
            ValueOfOneInUSD= valueOfOneInUSD;
        }

        public double ValueOfAsset()
        {
            return ValueOfOneInUSD;
        }
    }
}
