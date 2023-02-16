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
        Task<string> GetBlockTransactionCountByHashAsync(string blockHash);
        Task<string> GetBlockTransactionCountByNumberAsync(string blockNumber);
        Task<string> GetUncleCountByHashAsync(string blockHash);
        Task<string> GetUncleCountByNumberAsync(string blockNumber);
        Task<string> GetBalance(string address, string blockHash);
    }
}
