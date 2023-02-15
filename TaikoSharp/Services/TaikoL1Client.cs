using Nethereum.JsonRpc.Client;
using Nethereum.RPC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaikoSharp.Models;
using TaikoSharp.Helpers;

namespace TaikoSharp.Services
{
    public class TaikoL1Client : ITaikoL1Client
    {
        readonly RpcClient RpcClient;
        public TaikoL1Client()
        {
            RpcClient = new RpcClient(new Uri(TaikoConstants.L1RPCUrl));
        }
        public async Task<long> GetChainIdAsync()
        {
            RpcRequest rpcRequest = new RpcRequest(0, "eth_chainId");
            string rpcResponse = await RpcClient.SendRequestAsync<string>(rpcRequest);
            return Conversions.ToLongFromHexString(rpcResponse);
        }
    }
}
