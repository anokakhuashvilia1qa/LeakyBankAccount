using System;

public class BankAccount
{
	public BankAccount()
	{
		private double balance;
		private string owner;

        public void Withdraw(double amount)
        {
            // BUG: Does not check for negative amounts!
            if (amount > balance)
            {
                throw new ArgumentException("Insufficient funds!");
            }
            balance -= amount;
        }

        public void Deposit(double amount)
        {
            balance -= amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
