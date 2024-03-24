using System;

namespace BaseWallet
{
    public sealed class Wallet
    {
        private int _balance;

        public int Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                _balance = value;
                BalanceChanged?.Invoke();
            }
        }

        public event Action BalanceChanged;

        public bool HasMoney(int amount)
        {
            return _balance - amount >= 0;
        }

        public void TakeMoney(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            if (HasMoney(amount) == false)
            {
                Console.WriteLine($"Вы бомж. Пополните баланс на ${amount - _balance}");
                return;
            }

            Balance -= amount;
        }

        public void AddMoney(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            Balance += amount;
        }
    }
}
