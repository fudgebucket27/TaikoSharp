using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaikoSharp.Models
{
    public interface ITaikoL1Client
    {
        Task<long> GetChainIdAsync();
        Task<bool> GetSyncingStatusAsync();
        Task<long> GetLatestBlockNumberAsync();
        Task<BlockWithTransactionDetails> GetBlockByNumberWithTransactionDetailsAsync(string blockNumber);
        Task<BlockWithoutTransactionDetails> GetBlockByNumberWithoutTransactionDetailsAsync(string blockNumber);
    }
}
