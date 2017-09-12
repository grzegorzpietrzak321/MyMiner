using System.Collections.Generic;

namespace MyMiner
{
    public class Pool
    {
        public string PoolName { get; set; }
        public List<PoolAddress> PoolAddresses = new List<PoolAddress>();

        public void AddPoolAddress(PoolAddress poolAddress)
        {
            PoolAddresses.Add(poolAddress);
        }
    }
}