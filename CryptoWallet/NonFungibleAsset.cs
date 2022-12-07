using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    public class NonFungibleAsset
    {
        public Guid Address { get; }
        public string Name { get; set; }
        public double Value { get; set; }
        public Guid AddressOfFungibleAsset { get; }

        public NonFungibleAsset(string name,double value,FungibleAsset fungibleAsset)
        {
            Address = new Guid();
            Name = name;
            Value = value;
            AddressOfFungibleAsset= fungibleAsset.Address;
        }
    }
}
