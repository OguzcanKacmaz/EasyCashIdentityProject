﻿namespace EasyCash.EntityLayer.Concrete;

public class CustomerAccount
{
    public int CustomerAccountID { get; set; }
    public string CustomerAccountNumber { get; set; }
    public string CustomerAccountCurrency { get; set; }
    public decimal CustomerAccountBalance { get; set; }
    public string BankBranch { get; set; }
}