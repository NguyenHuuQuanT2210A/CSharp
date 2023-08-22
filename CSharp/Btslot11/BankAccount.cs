using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Btslot11
{
    public delegate void NotifyBalance(string msg);
    public class BankAccount
    {
        private decimal balance;
        public event NotifyBalance msgChangeBalance;
        public BankAccount() 
        {
            msgChangeBalance += NotifyEmail;
            msgChangeBalance += NotifySMS;
            msgChangeBalance += NotifyBanking;
        }
        private void NotifyEmail(string msg)
        {

        }
        private void NotifySMS(string msg)
        {

        }
        private void NotifyBanking(string msg)
        {

        }
        public decimal Balance
        {
            get => balance;
            set
            {
              if (balance != value)
                {
                    msgChangeBalance("Balance was changed: "+(value - balance));
                    balance = value;
                }
            }
        }

        
        public void Deposit(decimal n)
        {
            Balance = n > 0 ? Balance + n : Balance;
        }
        public void Withdraw(decimal n) 
        {
            Balance = Balance > n && n > 0 ? Balance - n : Balance;
        }

    }
}
