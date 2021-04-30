using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructType
{
    public enum AccountType { Checking, Deposit }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
    class Struct
    {
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            Console.WriteLine("Enter account number: ");
            string Temp = Console.ReadLine();

            goldAccount.accNo = long.Parse (Temp);




            printme(goldAccount);
        }
        static void printme(BankAccount account)
        {
            Console.WriteLine("Customers account number: {0}, Balance: {1}, Type: {2}",account.accNo,account.accBal,account.accType);

        }
    }
}
