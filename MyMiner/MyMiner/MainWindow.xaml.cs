using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
// ReSharper disable PossibleNullReferenceException

namespace MyMiner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            StatusBar.Text = Props.ShowVersion();
        }

        public List<Wallet> LoadWalletsFromFile()
        {
            var addresses = JsonConvert.DeserializeObject<List<Wallet>>(FileHandler.ReadFromFile("addresses.cfg"));

            TbxEth.Text = addresses.FirstOrDefault(p => p.Currency == "ETH").Address;
            CbxEth.Text = addresses.FirstOrDefault(p => p.Currency == "ETH").PoolName;

            TbxEtc.Text = addresses.FirstOrDefault(p => p.Currency == "ETC").Address;
            CbxEtc.Text = addresses.FirstOrDefault(p => p.Currency == "ETC").PoolName;

            TbxSia.Text = addresses.FirstOrDefault(p => p.Currency == "SIA").Address;
            CbxSia.Text = addresses.FirstOrDefault(p => p.Currency == "SIA").PoolName;

            TbxZcash.Text = addresses.FirstOrDefault(p => p.Currency == "ZCASH").Address;
            CbxZcash.Text = addresses.FirstOrDefault(p => p.Currency == "ZCASH").PoolName;

            TbxMusic.Text = addresses.FirstOrDefault(p => p.Currency == "MUSIC").Address;
            CbxMusic.Text = addresses.FirstOrDefault(p => p.Currency == "MUSIC").PoolName;

            TbxMonero.Text = addresses.FirstOrDefault(p => p.Currency == "MONERO").Address;
            CbxMonero.Text = addresses.FirstOrDefault(p => p.Currency == "MONERO").PoolName;

            TbxUbiq.Text = addresses.FirstOrDefault(p => p.Currency == "UBIQ").Address;
            CbxUbiq.Text = addresses.FirstOrDefault(p => p.Currency == "UBIQ").PoolName;

            TextBox1.Text = Guid.NewGuid().ToString().Replace("-", string.Empty);
            return addresses;
        }

        public void SaveWWalletsToFile()
        {
            List<Wallet> addressesesList = new List<Wallet>();

            addressesesList.Add(new Wallet("ETH", TbxEth.Text, CbxEth.Text));
            addressesesList.Add(new Wallet("ETC", TbxEtc.Text, CbxEtc.Text));
            addressesesList.Add(new Wallet("SIA", TbxSia.Text, CbxSia.Text));
            addressesesList.Add(new Wallet("ZCASH", TbxZcash.Text, CbxZcash.Text));
            addressesesList.Add(new Wallet("MUSIC", TbxMusic.Text, CbxMusic.Text));
            addressesesList.Add(new Wallet("MONERO", TbxMonero.Text, CbxMonero.Text));
            addressesesList.Add(new Wallet("UBIQ", TbxUbiq.Text, CbxUbiq.Text));
            addressesesList.Add(new Wallet("EXP", TbxExp.Text, CbxExp.Text));

            FileHandler.WriteToFile("addresses.cfg", JsonConvert.SerializeObject(addressesesList));
        }
    }
}
