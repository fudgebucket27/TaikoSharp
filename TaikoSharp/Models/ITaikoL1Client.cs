using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaikoSharp.Models
{
    public interface ITaikoL1Client
    {
        Task<string> GetChainIdAsync();
        Task<bool> GetSyncingStatusAsync();
        Task<string> GetLatestBlockNumberAsync();
        Task<BlockWithTransactionDetails> GetBlockByNumberWithTransactionDetailsAsync(string blockNumber);
        Task<BlockWithoutTransactionDetails> GetBlockByNumberWithoutTransactionDetailsAsync(string blockNumber);

        Task<BlockWithTransactionDetails> GetBlockByHashWithTransactionDetailsAsync(string blockHash);
        Task<BlockWithoutTransactionDetails> GetBlockByHashWithoutTransactionDetailsAsync(string blockHash);
    }
}
