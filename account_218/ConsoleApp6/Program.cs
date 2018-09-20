using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account("58030218", 10000);
            ac.Display();
            ac.Debit(300);
            ac.Credit(20000);
            ac.Debit(30000);
            ac.Display();
            ac.totalBalance();
        }
    }

    public class Account
    {
        private string accountName;
        private int accountBalance;
        private int creditBalance;
        public int total;
        public int debit;

        public void Credit(int amount)
        {
            Console.WriteLine("Credit {0} bath", amount);
            creditBalance += amount;
        }

        //
        public void Debit(int amount)
        {
           accountBalance = accountBalance + creditBalance;

            if (amount > accountBalance)
                Console.WriteLine("Sorry, you can't buy television there is not enough money");
            else
                Console.WriteLine("you withdraw {0},you have balance:{1}",amount,accountBalance -= amount);

        }

        //account balance
        public void Display()
        {
         
       
            Console.WriteLine("Name: {0}, Balance: {1 , 20:C}", 
                accountName,accountBalance);
          // Console.WriteLine("credit:{0}  debit:{1}", accountBalance-accountBalance, accountBalance-creditBalance);

            
        }
        // account name
        public Account(string accountName, int amount)
        {
            this.accountName = accountName;
            accountBalance = amount;
        }

        public void totalBalance()
        {
            debit = accountBalance - creditBalance;
            total = accountBalance + creditBalance;
            Console.WriteLine("credit : {0}  debit :{1}", total - accountBalance, debit);
        }
       
    }

}
