﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaikoSharp.Models
{
    public interface ITaikoL2Client
    {
        Task<int> GetChainIdAsync();
    }
}