using NUnit.Framework;
using System;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void StandardWithdrawal_ReducesBalance()
    {
        var account = new BankAccount("Ano");
        account.Deposit(100);

        account.Withdraw(30);

        Assert.That(account.GetBalance(), Is.EqualTo(70).Within(1e-6)); ;
    }

    [Test]
    public void Overdraw_ThrowsArgumentException()
    {
        var account = new BankAccount("Ano");
        account.Deposit(50);

        Assert.Throws<ArgumentException>(() => account.Withdraw(100));
    }

    [Test]
    public void Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        var account = new BankAccount("Ano");
        account.Deposit(100);

        Assert.Throws<ArgumentException>(() => account.Withdraw(-50));
    }
}
