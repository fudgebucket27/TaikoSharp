using TaikoSharp.Services;
TaikoL2Client taikoL2Client = new TaikoL2Client();
var chainID = await taikoL2Client.GetChainIDAsync();
Console.WriteLine($"Taiko L2 Chain ID: {chainID}");
Console.WriteLine("Enter to exit:");
Console.ReadLine();