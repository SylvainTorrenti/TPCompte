using TPCompte;

#region Customer
Customer Customer1 = new Customer("EE111222", "Omar", "Salim", "0611111111");
Customer Customer2 = new Customer("FF857465", "Toto", "Tutu", "0622222222");
#endregion
#region Account
Account Account1 = new Account(Customer1);
Account Account2 = new Account(Customer2);
#endregion
#region Display Account
Account1.DisplayAccount();
Account2.DisplayAccount();
#endregion
#region Credit account
Account1.Credit(25000);
Account2.CreditAccount(20000, Account1);
#endregion
Console.WriteLine("****************************");
#region Show after credit
Account1.DisplayAccount();
Account2.DisplayAccount();
#endregion
#region Witrhdraw account
Account1.Withdraw(1500);
Account2.WithdrawAccount(2000, Account1);
#endregion
Console.WriteLine("****************************");
#region Show after Withdraw
Account1.DisplayAccount();
Account2.DisplayAccount();
#endregion
Console.WriteLine($"Il y a eu {Account.DisplayAccountNB()} compte créé");