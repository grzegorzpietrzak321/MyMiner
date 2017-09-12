namespace MyMiner
{
    public class PoolAddress
    {
        public string Address { get; set; }
        public string Port { get; set; }

        public PoolAddress()
        {

        }

        public PoolAddress(string address, string port)
        {
            Address = address;
            Port = port;
        }
    }
}