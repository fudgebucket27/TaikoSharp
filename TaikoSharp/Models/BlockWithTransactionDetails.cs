using System;
using System.Collections.Generic;
using System.Text;

namespace TaikoSharp.Models
{
    public class AccessList
    {
        public string address { get; set; }
        public List<string> storageKeys { get; set; }
    }

    public class BlockWithTransactionDetails
    {
        public string baseFeePerGas { get; set; }
        public string difficulty { get; set; }
        public string extraData { get; set; }
        public string gasLimit { get; set; }
        public string gasUsed { get; set; }
        public string hash { get; set; }
        public string logsBloom { get; set; }
        public string miner { get; set; }
        public string mixHash { get; set; }
        public string nonce { get; set; }
        public string number { get; set; }
        public string parentHash { get; set; }
        public string receiptsRoot { get; set; }
        public string sha3Uncles { get; set; }
        public string size { get; set; }
        public string stateRoot { get; set; }
        public string timestamp { get; set; }
        public string totalDifficulty { get; set; }
        public List<Transaction> transactions { get; set; }
        public string transactionsRoot { get; set; }
        public List<string> uncles { get; set; }
    }

    public class Transaction
    {
        public List<AccessList> accessList { get; set; }
        public string blockHash { get; set; }
        public string blockNumber { get; set; }
        public string chainId { get; set; }
        public string from { get; set; }
        public string gas { get; set; }
        public string gasPrice { get; set; }
        public string hash { get; set; }
        public string input { get; set; }
        public string maxFeePerGas { get; set; }
        public string maxPriorityFeePerGas { get; set; }
        public string nonce { get; set; }
        public string r { get; set; }
        public string s { get; set; }
        public string to { get; set; }
        public string transactionIndex { get; set; }
        public string type { get; set; }
        public string v { get; set; }
        public string value { get; set; }
    }


}
