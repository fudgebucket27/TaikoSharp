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

namespace TaikoSharp.Services
{
    public class TaikoL1Client : ITaikoL1Client
    {
        readonly RpcClient RpcClient;
        public TaikoL1Client(string rpcURL)
        {
            RpcClient = new RpcClient(new Uri(rpcURL));
        }

        public async Task<BlockWithoutTransactionDetails> GetBlockByNumberWithoutTransactionDetailsAsync(string blockNumber)
        {
            object[] parameters = new object[] { Conversions.ToHexFromLong(long.Parse(blockNumber)), false };
            RpcRequest rpcRequest = new RpcRequest(0, "eth_getBlockByNumber", parameters);
            JObject rpcResponse = await RpcClient.SendRequestAsync<JObject>(rpcRequest);
            return rpcResponse.ToObject<BlockWithoutTransactionDetails>();
        }

        public async Task<BlockWithTransactionDetails> GetBlockByNumberWithTransactionDetailsAsync(string blockNumber) 
        {
            object[] parameters = new object[] { Conversions.ToHexFromLong(long.Parse(blockNumber)), true };
            RpcRequest rpcRequest = new RpcRequest(0, "eth_getBlockByNumber", parameters);
            JObject rpcResponse = await RpcClient.SendRequestAsync<JObject>(rpcRequest);
            return rpcResponse.ToObject<BlockWithTransactionDetails>();
        }

        public async Task<long> GetChainIdAsync()
        {
            RpcRequest rpcRequest = new RpcRequest(0, "eth_chainId");
            string rpcResponse = await RpcClient.SendRequestAsync<string>(rpcRequest);
            return Conversions.ToLongFromHexString(rpcResponse);
        }

        public async Task<long> GetLatestBlockNumberAsync()
        {
            RpcRequest rpcRequest = new RpcRequest(0, "eth_blockNumber");
            string rpcResponse = await RpcClient.SendRequestAsync<string>(rpcRequest);
            return Conversions.ToLongFromHexString(rpcResponse);
        }

        public async Task<bool> GetSyncingStatusAsync()
        {
            RpcRequest rpcRequest = new RpcRequest(0, "eth_syncing");
            bool rpcResponse = await RpcClient.SendRequestAsync<bool>(rpcRequest);
            return rpcResponse;
        }
    }
}
