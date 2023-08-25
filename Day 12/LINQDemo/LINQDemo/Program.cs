// See https://aka.ms/new-console-template for more information
using LINQDemo;

Console.WriteLine("Hello, World!");

#region Data
List<BankAccounts> accList = new List<BankAccounts>()
{
    new BankAccounts(){ accNo=1, accName="Karan", accType="Savings", accBalance=500, accBranchNo=10, accIsActive=true },
    new BankAccounts(){ accNo=2, accName="Mohan", accType="Current", accBalance=200, accBranchNo=20, accIsActive=false },
    new BankAccounts(){ accNo=3, accName="Suman", accType="Savings", accBalance=400, accBranchNo=20, accIsActive=true },
    new BankAccounts(){ accNo=4, accName="Rohit", accType="Savings", accBalance=600, accBranchNo=20, accIsActive=true },
    new BankAccounts(){ accNo=5, accName="Mukesh", accType="Current", accBalance=100, accBranchNo=10, accIsActive=false },
    new BankAccounts(){ accNo=6, accName="Ram", accType="Savings", accBalance=800, accBranchNo=10, accIsActive=true },
    new BankAccounts(){ accNo=7, accName="Dipti", accType="Savings", accBalance=1200, accBranchNo=40, accIsActive=true },
    new BankAccounts(){ accNo=8, accName="Pooja", accType="Savings", accBalance=2500, accBranchNo=10, accIsActive=true },
    new BankAccounts(){ accNo=9, accName="Poonam", accType="Savings", accBalance=100, accBranchNo=10, accIsActive=true },
    new BankAccounts(){ accNo=10, accName="Jyoti", accType="PF", accBalance=50, accBranchNo=40, accIsActive=false }
};
#endregion