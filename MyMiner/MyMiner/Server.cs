using System.Collections.Generic;

namespace MyMiner
{
    public class Server
    {
        public List<Pool> Pools = new List<Pool>();
        public string Currency { get; set; }

        public void AddPool(Pool pool)
        {
            Pools.Add(pool);
        }



    }
}