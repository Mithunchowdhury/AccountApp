using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    class PersonalAccount
    {
        public string accountNumber;
        public string customerNane;
        public double balance;


        public void Deposit(double depositAmount)
        {
            balance = balance + depositAmount;
        }

        public void Withdraw(double withdraw)
        {
            balance = balance - withdraw;
        }

        public string GetSummaryInfo()
        {
            return customerNane + " your accont number" + accountNumber + "and it is balance " + balance + "taka";



        }













    }




}
