using System;

namespace BaseWallet
{
    public sealed class WalletView
    {
        private Wallet _wallet;

        public WalletView(Wallet wallet)
        {
            _wallet = wallet;
        }

        public void Init() => _wallet.BalanceChanged += Show;
        public void Dispose() => _wallet.BalanceChanged -= Show;

        public void Show()
        {
            Console.WriteLine($"На вашем счету: ${_wallet.Balance}");
        }
    }
}
