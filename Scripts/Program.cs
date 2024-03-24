using System;

namespace BaseWallet
{
    public sealed class Program
    {
        private static void Main(string[] args)
        {
            var wallet = new Wallet();
            var walletView = new WalletView(wallet);

            walletView.Init();

            wallet.AddMoney(1000);
            wallet.TakeMoney(1001);

            Console.Read();

            walletView.Dispose();
        }
    }
}
