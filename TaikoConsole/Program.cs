using TaikoSharp.Services;
TaikoL1Client taikoL1Client = new TaikoL1Client("https://mainnet.infura.io/v3/53173af3389645d18c3bcac2ee9a751c");
TaikoL2Client taikoL2Client = new TaikoL2Client("https://mainnet.infura.io/v3/53173af3389645d18c3bcac2ee9a751c");

var taikoL1ChainID = await taikoL1Client.GetChainIdAsync();
Console.WriteLine($"Chain ID: {taikoL1ChainID}");

var taikoL1Syncing = await taikoL1Client.GetSyncingStatusAsync();
Console.WriteLine($"Syncing: {taikoL1Syncing}");

var taikoL1BlockNumber = await taikoL1Client.GetLatestBlockNumberAsync();
Console.WriteLine($"Latest Block Number: {taikoL1BlockNumber}");

var taikoL1BlockWithDetails = await taikoL1Client.GetBlockByNumberWithTransactionDetailsAsync(taikoL1BlockNumber);
Console.WriteLine($"Block By Number With Details 1st Transaction Gas Price:{taikoL1BlockWithDetails.transactions[0].gasPrice}");

var taikoL1BlockWithoutDetails = await taikoL1Client.GetBlockByNumberWithoutTransactionDetailsAsync(taikoL1BlockNumber);
Console.WriteLine($"Block By Number Without Details 1st Transaction Hash:{taikoL1BlockWithoutDetails.transactions[0]}");

var taikoL1BlockHashWithDetails = await taikoL1Client.GetBlockByHashWithTransactionDetailsAsync(taikoL1BlockWithDetails.hash);
Console.WriteLine($"Block By Hash With Details 1st Transaction Gas Price:{taikoL1BlockHashWithDetails.transactions[0].gasPrice}");

var taikoL1BlockHashWithoutDetails = await taikoL1Client.GetBlockByHashWithoutTransactionDetailsAsync(taikoL1BlockWithDetails.hash);
Console.WriteLine($"Block By Hash Without Details 1st Transaction Hash:{taikoL1BlockHashWithoutDetails.transactions[0]}");

var taikoL1TransactionCountByHash = await taikoL1Client.GetBlockTransactionCountByHashAsync(taikoL1BlockWithDetails.hash);
Console.WriteLine($"Block Transaction Count By Hash:{taikoL1TransactionCountByHash}");

var taikoL1TransactionCountByNumber = await taikoL1Client.GetBlockTransactionCountByNumberAsync(taikoL1BlockNumber);
Console.WriteLine($"Block Transaction Count By Number:{taikoL1TransactionCountByNumber}");

var taikoL1UncleCountByHash = await taikoL1Client.GetUncleCountByHashAsync(taikoL1BlockWithDetails.hash);
Console.WriteLine($"Block Uncle Count By Hash:{taikoL1UncleCountByHash}");

var taikoL1UncleCountByNumber = await taikoL1Client.GetUncleCountByNumberAsync(taikoL1BlockNumber);
Console.WriteLine($"Block Uncle Count By Number:{taikoL1UncleCountByNumber}");

var taikoL1Balance = await taikoL1Client.GetBalance("0x72760a5CE15158Da78b33968b423a52576178f91", "latest");
Console.WriteLine($"Balance: {taikoL1Balance}");

Console.WriteLine("Enter to exit:");
Console.ReadLine();