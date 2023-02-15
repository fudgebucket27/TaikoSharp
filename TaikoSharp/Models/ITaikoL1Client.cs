using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaikoSharp.Models
{
    public interface ITaikoL1Client
    {
        Task<long> GetChainIdAsync();
    }
}
