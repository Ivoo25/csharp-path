using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return balance switch
        {
            < 0 => 3.213f,
            < 1000 => 0.5f,
            < 5000 => 1.621f,
            _ => 2.475f
        };
        throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
    }

    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)InterestRate(balance) / 100;
        throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
        throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
        throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
    }
}
