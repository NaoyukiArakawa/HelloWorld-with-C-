using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Naoyuki", 1000);
            account.MakeWithdrawal(100, DateTime.Now, "Transportation cost");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(500, DateTime.Now, "Happy Birthday from mom");
            Console.WriteLine(account.Balance);

            // // Test that the initial balances must be positive.
            // try
            // {
            //     var invalidAccount = new BankAccount("invalid", -55);
            // }
            // catch (ArgumentOutOfRangeException e)
            // {
            //     Console.WriteLine("Exception caught creating account with negative balance");
            //     Console.WriteLine(e.ToString());
            // }

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}




