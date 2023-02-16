using Nethereum.JsonRpc.Client;
using Nethereum.Signer;
using Nethereum.Web3;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaikoSharp.Helpers;
using TaikoSharp.Models;

namespace TaikoSharp.Services
{
    public class TaikoL2Client : ITaikoL2Client
    {
        readonly RpcClient RpcClient;
        public TaikoL2Client(string rpcURL)
        {
            RpcClient = new RpcClient(new Uri(rpcURL));
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
