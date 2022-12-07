using CryptoWallet;

var fungibleAsset1 = new FungibleAsset("Bitcoin","BTC",16376);
var fungibleAsset2 = new FungibleAsset("Ethereum", "ETH", 1207);
var fungibleAsset3 = new FungibleAsset("Tether", "USDT", 1);
var fungibleAsset4 = new FungibleAsset("BNB", "BNB", 299);
var fungibleAsset5 = new FungibleAsset("USD Coin", "USDC", 1);
var fungibleAsset6 = new FungibleAsset("Binance USD", "BUSD", 1);
var fungibleAsset7 = new FungibleAsset("XRP", "XRP", 0.389);
var fungibleAsset8 = new FungibleAsset("Dodgecoin", "DOGE", 0.1001);
var fungibleAsset9 = new FungibleAsset("Cardano", "ADA", 0.3077);
var fungibleAsset10 = new FungibleAsset("Polygon", "MATIC", 0.8315);

var nonFungibleAsset1 = new NonFungibleAsset("Kuća1",250000,fungibleAsset3);
var nonFungibleAsset2 = new NonFungibleAsset("Kuća2", 2, fungibleAsset1);
var nonFungibleAsset3 = new NonFungibleAsset("Auto1", 1.56, fungibleAsset1);
var nonFungibleAsset4 = new NonFungibleAsset("Auto2", 1.86, fungibleAsset1);
var nonFungibleAsset5 = new NonFungibleAsset("Auto3", 2.35, fungibleAsset1);
var nonFungibleAsset6 = new NonFungibleAsset("Stan1", 200, fungibleAsset2);
var nonFungibleAsset7 = new NonFungibleAsset("Stan2", 150, fungibleAsset2);
var nonFungibleAsset8 = new NonFungibleAsset("Stan3", 170.7, fungibleAsset2);
var nonFungibleAsset9 = new NonFungibleAsset("Auto4", 183.36, fungibleAsset4);
var nonFungibleAsset10 = new NonFungibleAsset("Auto5", 207.6, fungibleAsset4);
var nonFungibleAsset11= new NonFungibleAsset("Salvador Mundi", 27479.24, fungibleAsset1);
var nonFungibleAsset12 = new NonFungibleAsset("Interchange", 248550.124, fungibleAsset2);
var nonFungibleAsset13 = new NonFungibleAsset("The Card Players", 18319.49, fungibleAsset1);
var nonFungibleAsset14 = new NonFungibleAsset("Doodle1", 7.78, fungibleAsset2);
var nonFungibleAsset15 = new NonFungibleAsset("Doodle2", 7.84, fungibleAsset2);
var nonFungibleAsset16 = new NonFungibleAsset("Doodle3", 8, fungibleAsset2);
var nonFungibleAsset17 = new NonFungibleAsset("Doodle4", 8.4, fungibleAsset2);
var nonFungibleAsset18 = new NonFungibleAsset("Azuki1", 13, fungibleAsset2);
var nonFungibleAsset19 = new NonFungibleAsset("Azuki2", 13.95, fungibleAsset2);
var nonFungibleAsset20 = new NonFungibleAsset("Azuki3", 14.03, fungibleAsset2);

var listOfFungibleAssets=new List<FungibleAsset>() { fungibleAsset1,fungibleAsset2,fungibleAsset3,fungibleAsset4,fungibleAsset5,
        fungibleAsset6,fungibleAsset7,fungibleAsset8,fungibleAsset9,fungibleAsset10};
var listOfNonFungibleAssets=new List<NonFungibleAsset>() { nonFungibleAsset1,nonFungibleAsset2,nonFungibleAsset3,nonFungibleAsset4,
    nonFungibleAsset5,nonFungibleAsset6,nonFungibleAsset7,nonFungibleAsset8,nonFungibleAsset9,nonFungibleAsset10,nonFungibleAsset11,
    nonFungibleAsset12,nonFungibleAsset13,nonFungibleAsset14,nonFungibleAsset15,nonFungibleAsset16,nonFungibleAsset17,nonFungibleAsset18,
    nonFungibleAsset19,nonFungibleAsset20};

var listOfFungibleAssetsAdresses = new List<Guid>();
foreach (var asset in listOfFungibleAssets)
{
    listOfFungibleAssetsAdresses.Add(asset.Address);
}

var listOfNonFungibleAssetAdresses = new List<Guid>();
foreach (var asset1 in listOfNonFungibleAssets)
{
    listOfNonFungibleAssetAdresses.Add(asset1.Address);
}

var balanceOfFungibleAssets=new Dictionary<Guid, int>();
foreach (var fungibleAsset in listOfFungibleAssets)
{
    var random = new Random();
    int quantity=random.Next(0,10000);
    balanceOfFungibleAssets.Add(fungibleAsset.Address, quantity);
}

var firstBitcoinWallet = new BitcoinWallet()
{
    BalanceOfFungibleAsset = balanceOfFungibleAssets,
    AdressesOfFungibleAssets= listOfFungibleAssetsAdresses
};
var secondBitcoinWallet = new BitcoinWallet()
{
    BalanceOfFungibleAsset = balanceOfFungibleAssets,
    AdressesOfFungibleAssets= listOfFungibleAssetsAdresses
};
var thirdBitcoinWallet = new BitcoinWallet()
{
    BalanceOfFungibleAsset = balanceOfFungibleAssets,
    AdressesOfFungibleAssets = listOfFungibleAssetsAdresses
};

var listOfAllAssetsAdresses = new List<Guid>();
foreach (var item in listOfFungibleAssetsAdresses)
{
    listOfAllAssetsAdresses.Add(item);
}
foreach (var asset in listOfNonFungibleAssetAdresses)
{
    listOfAllAssetsAdresses.Add(asset);
}

var firstEthereumWallet = new EthereumWallet()
{
    BalanceOfFungibleAsset = balanceOfFungibleAssets,
    AdressesOfFungibleAssets = listOfFungibleAssetsAdresses,
    AddressesOfNonFungibleAssets = listOfNonFungibleAssetAdresses,
    AddressesOfAssets = listOfAllAssetsAdresses
};
var secondEthereumWallet = new EthereumWallet()
{
    BalanceOfFungibleAsset = balanceOfFungibleAssets,
    AdressesOfFungibleAssets = listOfFungibleAssetsAdresses,
    AddressesOfNonFungibleAssets = listOfNonFungibleAssetAdresses,
    AddressesOfAssets = listOfAllAssetsAdresses
};
var thirdEthereumWallet = new EthereumWallet()
{
    BalanceOfFungibleAsset = balanceOfFungibleAssets,
    AdressesOfFungibleAssets = listOfFungibleAssetsAdresses,
    AddressesOfNonFungibleAssets = listOfNonFungibleAssetAdresses,
    AddressesOfAssets = listOfAllAssetsAdresses
};

var firstSolanaWallet = new SolanaWallet()
{
    BalanceOfFungibleAsset = balanceOfFungibleAssets,
    AdressesOfFungibleAssets = listOfFungibleAssetsAdresses,
    AddressesOfNonFungibleAssets = listOfNonFungibleAssetAdresses,
    AddressesOfAssets = listOfAllAssetsAdresses
};
var secondSolanaWallet = new SolanaWallet()
{
    BalanceOfFungibleAsset = balanceOfFungibleAssets,
    AdressesOfFungibleAssets = listOfFungibleAssetsAdresses,
    AddressesOfNonFungibleAssets = listOfNonFungibleAssetAdresses,
    AddressesOfAssets = listOfAllAssetsAdresses
};
var thirdSolanaWallet = new SolanaWallet()
{
    BalanceOfFungibleAsset = balanceOfFungibleAssets,
    AdressesOfFungibleAssets = listOfFungibleAssetsAdresses,
    AddressesOfNonFungibleAssets = listOfNonFungibleAssetAdresses,
    AddressesOfAssets = listOfAllAssetsAdresses
};

var listOfBitcoinWallets=new List<BitcoinWallet>() { firstBitcoinWallet,secondBitcoinWallet,thirdBitcoinWallet};
var listOfEthereumWallets = new List<EthereumWallet>() { firstEthereumWallet, secondEthereumWallet, thirdEthereumWallet };
var listOfSolanaWallets = new List<SolanaWallet>() { firstSolanaWallet, secondSolanaWallet, thirdSolanaWallet };

MainMenu(listOfBitcoinWallets, listOfEthereumWallets, listOfSolanaWallets, listOfFungibleAssetsAdresses, listOfNonFungibleAssetAdresses,
        listOfFungibleAssets, listOfNonFungibleAssets);



static void MainMenu(List<BitcoinWallet> bitcoinWallets,List<EthereumWallet> ethereumWallets,List<SolanaWallet> solanaWallets,
        List<Guid> fungibleAssetsAdresses,List<Guid> nonFungibleAssetsAdresses, List<FungibleAsset> fungibleAssetsList, List<NonFungibleAsset> nonFungibleAssetsList)
{
    var input = "";
    do
    {
        Console.WriteLine("Odaberite radnju:\n1 - Kreiraj Wallet\n2 - Pristupi Walletu");
        input=Console.ReadLine();
    } while (input!="1"&input!="2");

    switch (input)
    {
        case "1":
            CreateWallet( bitcoinWallets, ethereumWallets, solanaWallets,fungibleAssetsAdresses, nonFungibleAssetsAdresses, fungibleAssetsList,nonFungibleAssetsList);
            break;
        case"2":

            break;
        default:
            Console.WriteLine("Krivi unos");
            break;
    }
}

static void CreateWallet(List<BitcoinWallet> bitcoinWallets, List<EthereumWallet> ethereumWallets, List<SolanaWallet> solanaWallets,
        List<Guid> fungibleAssetsAdresses, List<Guid> nonFungibleAssetsAdresses, List<FungibleAsset> fungibleAssets, List<NonFungibleAsset> nonFungibleAssets)
{
    var availableChoices=new List<string>() { "0","1","2","3"};
    var input = "";
    do
    {
        Console.WriteLine("Odaberite koji wallet želite kreirati:\n1-Bitcoin wallet\n2-Ethereum wallet\n3-Solana wallet\n0-Povratak na glavni menu");
        input=Console.ReadLine();
    } while (!availableChoices.Contains(input));

    switch (input)
    {
        case "1":
            var noviWallet = new BitcoinWallet(); 
            noviWallet.AdressesOfFungibleAssets = fungibleAssetsAdresses;
            bitcoinWallets.Add(noviWallet);
            MainMenu(bitcoinWallets, ethereumWallets, solanaWallets, fungibleAssetsAdresses, nonFungibleAssetsAdresses,fungibleAssets,nonFungibleAssets);
            break;
            
        case "2":
            var noviWallet1=new EthereumWallet();
            noviWallet1.AdressesOfFungibleAssets= fungibleAssetsAdresses;
            noviWallet1.AddressesOfNonFungibleAssets = nonFungibleAssetsAdresses;
            MainMenu(bitcoinWallets, ethereumWallets, solanaWallets, fungibleAssetsAdresses, nonFungibleAssetsAdresses, fungibleAssets, nonFungibleAssets);
            break;
        case"3":
            var noviWallet2 = new SolanaWallet();
            noviWallet2.AdressesOfFungibleAssets = fungibleAssetsAdresses;
            noviWallet2.AddressesOfNonFungibleAssets = nonFungibleAssetsAdresses;
            MainMenu(bitcoinWallets, ethereumWallets, solanaWallets, fungibleAssetsAdresses, nonFungibleAssetsAdresses, fungibleAssets, nonFungibleAssets);
            break;
        case "0":
            MainMenu(bitcoinWallets, ethereumWallets, solanaWallets, fungibleAssetsAdresses, nonFungibleAssetsAdresses, fungibleAssets, nonFungibleAssets);
            break;
        default:
            break;
    }
}

static void AccessWallet(List<BitcoinWallet> bitcoinWallets, List<EthereumWallet> ethereumWallets, List<SolanaWallet> solanaWallets,
    List<FungibleAsset> fungibleAssets,List<NonFungibleAsset> nonFungibleAssets)
{
    var availableChoices = new List<string>();
    foreach (var walletB in bitcoinWallets)
    {
        Console.WriteLine($"Tip walleta: Bitcoin\nAdresa: {walletB.Address}\nUkupna vrijednost asseta u USD: {walletB.GetTotalValueOfAllAssets(fungibleAssets)}USD");
        availableChoices.Add(walletB.Address.ToString());
    }
    foreach (var walletE in ethereumWallets)
    {
        Console.WriteLine($"Tip walleta: Ethereum\nAdresa: {walletE.Address}\nUkupna vrijednost asseta u USD: {walletE.GetTotalValueOfAllAssets(fungibleAssets,nonFungibleAssets)}USD");
        availableChoices.Add(walletE.Address.ToString());
    }
    foreach (var walletS in solanaWallets)
    {
        Console.WriteLine($"Tip walleta: Solana\nAdresa: {walletS.Address}\nUkupna vrijednost asseta u USD: {walletS.GetTotalValueOfAllAssets(fungibleAssets, nonFungibleAssets)}USD");
        availableChoices.Add(walletS.Address.ToString());
    }

    var inputedString="";
    do
    {
        Console.WriteLine("Unesite adresu walleta:");
        inputedString = Console.ReadLine();
    } while (!availableChoices.Contains(inputedString));

    Submenu(inputedString,bitcoinWallets,ethereumWallets,solanaWallets,fungibleAssets,nonFungibleAssets);
}

static void Submenu(string stringAddress, List<BitcoinWallet> bitcoinWallets, List<EthereumWallet> ethereumWallets, List<SolanaWallet> solanaWallets,
    List<FungibleAsset> fungibleAssets, List<NonFungibleAsset> nonFungibleAssets)
{
    var availableChoices = new List<string>() { "0", "1", "2", "3" };
    var input = "";
    do
    {
        Console.WriteLine("1-Portfolio\n2-Transfer\n3-Povijest transakcija\n0-Povratak na inicijalni menu");
        input = Console.ReadLine();
    } while (!availableChoices.Contains(input));

    switch (input)
    {
        case "1":
            foreach (var item1 in bitcoinWallets)
            {
                if (item1.Address.ToString()==stringAddress)
                {
                    item1.GetFungibleAsset(fungibleAssets);
                }
            }
            foreach (var item2 in ethereumWallets)
            {
                if (item2.Address.ToString() == stringAddress)
                {
                    item2.GetAsset(fungibleAssets, nonFungibleAssets);
                }
            }
            foreach (var item3 in solanaWallets)
            {
                if (item3.Address.ToString() == stringAddress)
                {
                    item3.GetAsset(fungibleAssets, nonFungibleAssets);
                }
            }
            break;

        case "2":

            break;
        case "3":
            break;
        case "0":
            AccessWallet(bitcoinWallets, ethereumWallets, solanaWallets, fungibleAssets, nonFungibleAssets);
            break;
        default:
            break;
    }

}


