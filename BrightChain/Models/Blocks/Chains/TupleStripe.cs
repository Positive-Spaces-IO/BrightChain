﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightChain.Models.Blocks.Chains
{
    public struct TupleStripe
    {
        public readonly int TupleCount { get; }
        public readonly IEnumerable<Block> Blocks { get; }

        public TupleStripe(int tupleCount, IEnumerable<Block> blocks)
        {
            this.TupleCount = tupleCount;
            this.Blocks = blocks;
        }
    }
}
