using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    public class NonFungibleAssetTransaction
    {
        public Guid Id { get; }
        public Guid AddressOfAsset { get; }
        public DateTime Date { get; }
        public Guid AddressOfSender { get; }
        public Guid AddressOfRecipient { get; }
        public bool IsCancelled { get; }

        public NonFungibleAssetTransaction(NonFungibleAsset asset,DateTime date,Guid addresOfSender,Guid adressOfRecipient)
        {
            Id=Guid.NewGuid();
            AddressOfAsset = asset.Address;
            Date= date;
            AddressOfSender = addresOfSender;
            AddressOfRecipient= adressOfRecipient;
            IsCancelled= true;
        }
    }
}
