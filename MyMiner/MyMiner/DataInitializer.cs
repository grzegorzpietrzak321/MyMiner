using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMiner
{
    public static class DataInitializer
    {
        static public List<Server> CreateServers()
        {
            List<Server> servers = new List<Server>();

            #region ETH
            Server server = new Server();
            Pool pool = new Pool();

            server.Currency = "ETH";
            pool.PoolName = "ethermine.org";
            pool.AddPoolAddress(new PoolAddress("eu1.ethermine.org", "4444"));
            pool.AddPoolAddress(new PoolAddress("eu1.ethermine.org", "14444"));
            pool.AddPoolAddress(new PoolAddress("us1.ethermine.org", "4444"));
            pool.AddPoolAddress(new PoolAddress("us1.ethermine.org", "14444"));
            pool.AddPoolAddress(new PoolAddress("us2.ethermine.org", "4444"));
            pool.AddPoolAddress(new PoolAddress("us2.ethermine.org", "14444"));
            pool.AddPoolAddress(new PoolAddress("asia1.ethermine.org", "4444"));
            pool.AddPoolAddress(new PoolAddress("asia1.ethermine.org", "14444"));
            server.AddPool(pool);

            Pool pool2 = new Pool();
            pool2.PoolName = "nanopool.org";
            pool2.AddPoolAddress(new PoolAddress("eth-eu1.nanopool.org", "9999"));
            pool2.AddPoolAddress(new PoolAddress("eth-eu2.nanopool.org", "9999"));
            pool2.AddPoolAddress(new PoolAddress("eth-us-east1.nanopool.org", "9999"));
            pool2.AddPoolAddress(new PoolAddress("eth-us-west1.nanopool.org", "9999"));
            pool2.AddPoolAddress(new PoolAddress("eth-asia1.nanopool.org", "9999"));
            server.AddPool(pool2);

            Pool pool3 = new Pool();
            pool3.PoolName = "ethpool.pl";
            pool3.AddPoolAddress(new PoolAddress("79.98.144.28", "8008"));
            server.AddPool(pool3);
            servers.Add(server);
            #endregion

            #region ETC
            Server server1 = new Server();
            Pool pool4 = new Pool();

            server1.Currency = "ETC";
            pool4.PoolName = "ethermine.org";
            pool4.AddPoolAddress(new PoolAddress("eu1-etc.ethermine.org", "4444"));
            pool4.AddPoolAddress(new PoolAddress("eu1-etc.ethermine.org", "14444"));
            pool4.AddPoolAddress(new PoolAddress("us1-etc.ethermine.org", "4444"));
            pool4.AddPoolAddress(new PoolAddress("us1-etc.ethermine.org", "14444"));
            server1.AddPool(pool4);

            Pool pool5 = new Pool();
            pool5.PoolName = "nanopool.org";
            pool5.AddPoolAddress(new PoolAddress("etc-eu1.nanopool.org", "19999"));
            pool5.AddPoolAddress(new PoolAddress("etc-eu2.nanopool.org", "19999"));
            pool5.AddPoolAddress(new PoolAddress("etc-us-east1.nanopool.org", "19999"));
            pool5.AddPoolAddress(new PoolAddress("etc-us-west1.nanopool.org", "19999"));
            pool5.AddPoolAddress(new PoolAddress("etc-asia1.nanopool.org", "19999"));
            server1.AddPool(pool5);

            Pool pool6 = new Pool();
            pool6.PoolName = "etcpool.pl";
            pool6.AddPoolAddress(new PoolAddress("79.98.144.27", "8008"));
            server1.AddPool(pool6);
            servers.Add(server1);
            #endregion

            #region SIA
            Server serverSIA = new Server();
            Pool poolSIA = new Pool();
            serverSIA.Currency = "SIA";
            poolSIA.PoolName = "nanopool.org";

            poolSIA.AddPoolAddress(new PoolAddress("sia-eu1.nanopool.org", "7777"));
            poolSIA.AddPoolAddress(new PoolAddress("sia-eu2.nanopool.org", "7777"));
            poolSIA.AddPoolAddress(new PoolAddress("sia-us-east1.nanopool.org", "7777"));
            poolSIA.AddPoolAddress(new PoolAddress("sia-us-west1.nanopool.org", "7777"));
            poolSIA.AddPoolAddress(new PoolAddress("sia-asia1.nanopool.org", "7777"));

            serverSIA.AddPool(poolSIA);
            servers.Add(serverSIA);

            #endregion

            #region ZCASH
            Server serverZCASH = new Server();

            Pool poolZEC1 = new Pool();
            serverZCASH.Currency = "ZCASH";
            poolZEC1.PoolName = "ethermine.org";
            poolZEC1.AddPoolAddress(new PoolAddress("eu1-zcash.flypool.org", "3333"));
            poolZEC1.AddPoolAddress(new PoolAddress("eu1-zcash.flypool.org", "13333"));
            poolZEC1.AddPoolAddress(new PoolAddress("asia1-zcash.flypool.org", "3333"));
            poolZEC1.AddPoolAddress(new PoolAddress("asia1-zcash.flypool.org", "13333"));
            poolZEC1.AddPoolAddress(new PoolAddress("cn1-zcash.flypool.org", "3333"));
            poolZEC1.AddPoolAddress(new PoolAddress("cn1-zcash.flypool.org", "13333"));
            poolZEC1.AddPoolAddress(new PoolAddress("us1-zcash.flypool.org", "3333"));
            poolZEC1.AddPoolAddress(new PoolAddress("us1-zcash.flypool.org", "13333"));
            serverZCASH.AddPool(poolZEC1);

            Pool poolZEC2 = new Pool();
            poolZEC2.PoolName = "nanopool.org";
            poolZEC2.AddPoolAddress(new PoolAddress("zec-eu1.nanopool.org", "6666"));
            poolZEC2.AddPoolAddress(new PoolAddress("zec-eu2.nanopool.org", "6666"));
            poolZEC2.AddPoolAddress(new PoolAddress("zec-us-east1.nanopool.org", "6666"));
            poolZEC2.AddPoolAddress(new PoolAddress("zec-us-west1.nanopool.org", "6666"));
            poolZEC2.AddPoolAddress(new PoolAddress("zec-asia1.nanopool.org", "6666"));
            serverZCASH.AddPool(poolZEC2);

            servers.Add(serverZCASH);
            #endregion

            #region EXP
            Server serverExp = new Server();

            Pool poolExp = new Pool();
            serverExp.Currency = "EXP";
            poolExp.PoolName = "exppool.pl";
            poolExp.AddPoolAddress(new PoolAddress("79.98.144.28", "8077"));
            serverExp.AddPool(poolExp);
            servers.Add(serverExp);
            #endregion

            #region MUSIC

            Server serverMUSIC = new Server();

            Pool poolMUSIC = new Pool();
            serverMUSIC.Currency = "MUSIC";
            poolMUSIC.PoolName = "nomnom.technology";
            poolMUSIC.AddPoolAddress(new PoolAddress("musicoin.nomnom.technology", "9999"));
            poolMUSIC.AddPoolAddress(new PoolAddress("musicoin.nomnom.technology", "4444"));
            poolMUSIC.AddPoolAddress(new PoolAddress("musicoin2.nomnom.technology", "9999"));
            poolMUSIC.AddPoolAddress(new PoolAddress("musicoin2.nomnom.technology", "4444"));
            serverMUSIC.AddPool(poolMUSIC);
            servers.Add(serverMUSIC);
            #endregion

            return servers;
        }

    }
}
