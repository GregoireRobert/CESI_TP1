namespace CESI_TP1;

public class BankAccount
{
    private double AccountBalance { get; set; }
    private double TaxRate { get; set; }

    public double GetAccountBalance()
    {
        double balance = GetBalanceAfterTax();
        return balance;
    }

    private double GetBalanceAfterTax()
    {
        return AccountBalance * TaxRate;
    }
}