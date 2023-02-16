using Nethereum.JsonRpc.Client;
using Nethereum.RPC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaikoSharp.Models;
using TaikoSharp.Helpers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Nethereum.Web3;

namespace TaikoSharp.Services
{
    public class TaikoL1Client : ITaikoL1Client
    {
        readonly Web3 Web3Client;
        public TaikoL1Client(string rpcURL)
        {
            Web3Client = new Web3(rpcURL);
        }

        public async Task<string> GetBalance(string address, string blockHash)
        {
            object[] parameters = new object[] { address, blockHash};
            RpcRequest rpcRequest = new RpcRequest(0, "eth_getBalance", parameters);
            string rpcResponse = await Web3Client.Client.SendRequestAsync<string>(rpcRequest);
            return rpcResponse;
        }

        public async Task<BlockWithoutTransactionDetails> GetBlockByHashWithoutTransactionDetailsAsync(string blockHash)
        {
            object[] parameters = new object[] { blockHash, false };
            RpcRequest rpcRequest = new RpcRequest(0, "eth_getBlockByHash", parameters);
            JObject rpcResponse = await Web3Client.Client.SendRequestAsync<JObject>(rpcRequest);
            return rpcResponse.ToObject<BlockWithoutTransactionDetails>();
        }

        public async Task<BlockWithTransactionDetails> GetBlockByHashWithTransactionDetailsAsync(string blockHash)
        {
            object[] parameters = new object[] { blockHash, true };
            RpcRequest rpcRequest = new RpcRequest(0, "eth_getBlockByHash", parameters);
            JObject rpcResponse = await Web3Client.Client.SendRequestAsync<JObject>(rpcRequest);
            return rpcResponse.ToObject<BlockWithTransactionDetails>();
        }

        public async Task<BlockWithoutTransactionDetails> GetBlockByNumberWithoutTransactionDetailsAsync(string blockNumber)
        {
            object[] parameters = new object[] { blockNumber, false };
            RpcRequest rpcRequest = new RpcRequest(0, "eth_getBlockByNumber", parameters);
            JObject rpcResponse = await Web3Client.Client.SendRequestAsync<JObject>(rpcRequest);
            return rpcResponse.ToObject<BlockWithoutTransactionDetails>();
        }

        public async Task<BlockWithTransactionDetails> GetBlockByNumberWithTransactionDetailsAsync(string blockNumber) 
        {
            object[] parameters = new object[] { blockNumber, true };
            RpcRequest rpcRequest = new RpcRequest(0, "eth_getBlockByNumber", parameters);
            JObject rpcResponse = await Web3Client.Client.SendRequestAsync<JObject>(rpcRequest);
            return rpcResponse.ToObject<BlockWithTransactionDetails>();
        }

        public async Task<string> GetBlockTransactionCountByHashAsync(string blockHash)
        {
            object[] parameters = new object[] { blockHash};
            RpcRequest rpcRequest = new RpcRequest(0, "eth_getBlockTransactionCountByHash", parameters);
            string rpcResponse = await Web3Client.Client.SendRequestAsync<string>(rpcRequest);
            return rpcResponse;
        }

        public async Task<string> GetBlockTransactionCountByNumberAsync(string blockNumber)
        {
            object[] parameters = new object[] { blockNumber};
            RpcRequest rpcRequest = new RpcRequest(0, "eth_getBlockTransactionCountByNumber", parameters);
            string rpcResponse = await Web3Client.Client.SendRequestAsync<string>(rpcRequest);
            return rpcResponse;
        }

        public async Task<string> GetChainIdAsync()
        {
            RpcRequest rpcRequest = new RpcRequest(0, "eth_chainId");
            string rpcResponse = await Web3Client.Client.SendRequestAsync<string>(rpcRequest);
            return rpcResponse;
        }

        public async Task<string> GetLatestBlockNumberAsync()
        {
            RpcRequest rpcRequest = new RpcRequest(0, "eth_blockNumber");
            string rpcResponse = await Web3Client.Client.SendRequestAsync<string>(rpcRequest);
            return rpcResponse;
        }

        public async Task<bool> GetSyncingStatusAsync()
        {
            RpcRequest rpcRequest = new RpcRequest(0, "eth_syncing");
            bool rpcResponse = await Web3Client.Client.SendRequestAsync<bool>(rpcRequest);
            return rpcResponse;
        }

        public async Task<string> GetUncleCountByHashAsync(string blockHash)
        {
            object[] parameters = new object[] { blockHash };
            RpcRequest rpcRequest = new RpcRequest(0, "eth_getUncleCountByBlockHash", parameters);
            string rpcResponse = await Web3Client.Client.SendRequestAsync<string>(rpcRequest);
            return rpcResponse;
        }

        public async Task<string> GetUncleCountByNumberAsync(string blockNumber)
        {
            object[] parameters = new object[] { blockNumber };
            RpcRequest rpcRequest = new RpcRequest(0, "eth_getUncleCountByBlockNumber", parameters);
            string rpcResponse = await Web3Client.Client.SendRequestAsync<string>(rpcRequest);
            return rpcResponse;
        }
    }
}
