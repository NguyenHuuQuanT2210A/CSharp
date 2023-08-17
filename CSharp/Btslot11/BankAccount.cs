using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Btslot11
{
    public delegate void BalanceHandler(decimal n);
    public class BankAccount
    {
        private decimal balance;
        public event BalanceHandler BalanceChanged;
        public BankAccount() 
        {
            BalanceChanged += NotifyChangeBalance;
            BalanceChanged += Deposit;
            BalanceChanged += Withdraw;
        }

        public decimal Balance
        {
            get => balance;
            set => balance = value;
        }

        public void NotifyChangeBalance(decimal n)
        {
            Console.WriteLine("Balance of Account was changed: " + n);
        }
        public void Deposit(decimal n)
        {
            if (n > 0)
            {
                Balance += n;
                BalanceChanged(n);
            }

        }
        public void Withdraw(decimal n) 
        {
            if (n > Balance)
            {
                throw new ArgumentException("So tien rut vuot qua so tien trong tai khoan");
            }
            Balance -= n;
        }

    }
}
