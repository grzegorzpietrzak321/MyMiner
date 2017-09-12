namespace MyMiner
{
    public class Wallet
    {
        public string Currency { get; set; }
        public string Address { get; set; }
        public string PoolName { get; set; }

        public Wallet(string curr, string addr, string poolna)
        {
            Currency = curr;
            Address = addr;
            PoolName = poolna;
        }
    }
}
