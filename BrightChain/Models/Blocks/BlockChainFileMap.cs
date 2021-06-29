using BrightChain.Enumerations;
using BrightChain.Interfaces;
using System;
using System.Collections.Generic;

namespace BrightChain.Models.Blocks
{
    /// <summary>
    /// Represents a virtual map of all the contituent tuple-sets/blocks in a given source/reconstructed file. These cannot themselves be committed to disk
    /// The block datas may not actually be loaded in memory, but the appropriate blocks will be loaded (all non-local will be pulled into the cache first) relative to their access offsets.
    /// </summary>
    public class BlockChainFileMap : ConstituentBlockListBlock
    {
        public BlockChainFileMap(ICacheManager<BlockHash, TransactableBlock> cacheManager, BlockSize blockSize, DateTime requestTime, DateTime keepUntilAtLeast, RedundancyContractType redundancy, BlockHash finalDataHash, IEnumerable<Block> constituentBlocks) : base(cacheManager: cacheManager, blockSize: blockSize, requestTime: requestTime, keepUntilAtLeast: keepUntilAtLeast, redundancy: redundancy, finalDataHash: finalDataHash, constituentBlocks: constituentBlocks, allowCommit: false)
        {
        }
    }
}
