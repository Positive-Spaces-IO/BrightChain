﻿using BrightChain.Enumerations;
using System.Collections.Generic;

namespace BrightChain.Models.Units
{
    public static class ByteStorageRedundancyDurationCostMap
    {
        /** Cost per unit
         */
        public static readonly Dictionary<RedundancyContractType, double> Map = new Dictionary<RedundancyContractType, double> {
            {RedundancyContractType.LocalNone, 0 },
            {RedundancyContractType.LocalMirror, 0 },
            {RedundancyContractType.HeapAuto, 0 },
            {RedundancyContractType.HeapLowPriority, 0 },
            {RedundancyContractType.HeapHighPriority, 0 },
        };

        public static double Cost(RedundancyContractType redundancy)
        {
            if (!ByteStorageRedundancyDurationCostMap.Map.ContainsKey(redundancy))
                throw new KeyNotFoundException(message: nameof(redundancy));

            return ByteStorageRedundancyDurationCostMap.Map[redundancy];
        }
    }
}
