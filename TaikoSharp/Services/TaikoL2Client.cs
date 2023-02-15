using Nethereum.JsonRpc.Client;
using Nethereum.Signer;
using Nethereum.Web3;
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
        public TaikoL2Client()
        {
            RpcClient = new RpcClient(new Uri(TaikoConstants.L2RPCUrl));
        }

        public async Task<int> GetChainIDAsync()
        {
           RpcRequest rpcRequest = new RpcRequest(0, "eth_chainId");
           string rpcResponse = await RpcClient.SendRequestAsync<string>(rpcRequest);
           return int.Parse(rpcResponse.Substring(2), System.Globalization.NumberStyles.HexNumber);
        }
    }
}
