using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Data;
using System;

namespace CSBasics
{
    public abstract class Account : IAccount
    {
        private decimal balance = 0;
        public abstract string RudeLetterString();
        public virtual bool WithdrawFunds (decimal amount)
        {
            if (balance < amount)
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }
        public void PayInFunds (decimal amount)
        {
            balance = balance + amount;
        }
        public decimal GetBalance ()
        {
            return balance;
        }
        //private decimal balance = 0;
        const int MAX_CUST = 100;
        #region AccountClass
        // public bool WithdrawFunds (decimal amount)
        // {
        //     if (balance < amount)
        //     {
        //         return false;
        //     }
        //     balance = balance - amount;
        //     return true;
        // }
        // public void PayInFunds (decimal amount)
        // {
        //     balance = balance + amount;
        // }
        // public decimal GetBalance ()
        // {
        //     return balance;
        // }
        #endregion
        public static bool AccountAllowed ( decimal income, int age)
        {
            if((income >= 10000) && (age >= 18))
            {
                return true;
            }
            else{
                return false;
            }
        }
        #region ENUMERATION
        //public enum AccountState 
        // {
        //     New,
        //     UnderAudit,
        //     Active,
        //     Frozen,
        //     Closed
        //};
        #endregion

        
        #region STRUCTS
        // public struct Account
        // {
        //     public AccountState State;
        //     public string Name;
        //     public string Address;
        //     public int AccountNumber;
        //     public int Balance;
        //     public int Overdraft;
        //};
        #endregion

        
        #region STRUCTMETHOD
        // public static void PrintAccount(Account a)
        // {
        //     Console.WriteLine("Name: " + a.Name);
        //     Console.WriteLine("Address: " + a.Address);
        //     Console.WriteLine("Balance: " + a.Balance);
        // }
        #endregion

        static void Main(string[] args)
        {
            #region GlazingCompany
            // double width, height, woodLength, glassArea;

            // const double MAX_WIDTH = 5.0 ;
            // const double MIN_WIDTH = 0.5 ;
            // const double MAX_HEIGHT = 3.0 ;
            // const double MIN_HEIGHT = 0.75 ;

            // string widthString, heightString;

            // Comments.SayThis();
            // do {
            //     Console.Write ("Give the width of the window between " +
            //      MIN_WIDTH + " and " + MAX_WIDTH + " :" );
            //      widthString = Console.ReadLine();
            //      width = double.Parse(widthString);
            // } while ( width < MIN_WIDTH || width > MAX_WIDTH );

            // do {
            //     Console.Write ("Give the height of the window between " +
            //      MIN_HEIGHT + " and " + MAX_HEIGHT + " :" );
            //      heightString = Console.ReadLine();
            //      height = double.Parse(heightString);
            // } while ( height < MIN_HEIGHT ||height > MAX_HEIGHT );
            #endregion            
            
            #region STREAMWRITER
            // try
            // {
            // StreamWriter writer;
            // writer = new StreamWriter("file.txt");
            // writer.WriteLine("Hello, My name is Usenmfon Uko");
            // writer.Close();
            // }
            // catch(Exception e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            #endregion
            
            #region STREAMREADER
            // try
            // {
            // string path;
            // path = @"C:\Users\Usenmfon\Desktop\2019 useful website.txt";
            // StreamReader reader;
            // reader = new StreamReader(path);
            // while(reader.EndOfStream == false)
            // {
            //     string line = reader.ReadLine();
            //     Console.WriteLine(line);
            // }
            // reader.Close();
            // }
            // catch(Exception e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            #endregion

            #region GlazingInstruct
            // double woodLength, glassArea;

            // double windowWidth = UsefulMethod.ReadValue(
            //     "Enter width of window: ", UsefulMethod.MIN_WIDTH, UsefulMethod.MAX_WIDTH);
            // Console.WriteLine("Width: " + windowWidth);

            // double windowHeight =  UsefulMethod.ReadValue(
            //     "Enter height of window: ", UsefulMethod.MIN_HEIGHT, UsefulMethod.MAX_HEIGHT);
            // Console.WriteLine("Height: " + windowHeight);

            // woodLength = 2 * ( windowWidth + windowHeight) * 3.25;
            // glassArea = 2 * ( windowWidth * windowHeight );

            // Console.WriteLine ( "The length of the wood is " +
            //     woodLength + " feet");
            // Console.WriteLine ( "The area of the glass is " +
            //     glassArea + " square metres");
            #endregion

            #region IMPLEMENTATION
            //     const int MAX_CUST = 50;

            //     AccountState [] states = new AccountState [MAX_CUST];
            //     string [] names =  new string [MAX_CUST];
            //     string [] addresses = new string [MAX_CUST];
            //     string [] accountNos = new string [MAX_CUST];
            //     string [] balances = new string [MAX_CUST];
            //     string [] overdraft = new string [MAX_CUST];

            //    const int MAX_CUS = 100;
            //    Account[] Bank =  new Account[MAX_CUS];
            //    Bank[0].Name = "Rob";
            //    Bank[0].State = AccountState.Active;
            //    Bank[0].Balance = 100000;
            //    Bank[1].Name = "Jim";
            //    Bank[1].State = AccountState.Frozen;
            //    Bank[1].Balance = 0;
            //    PrintAccount(Bank[0]);
            //    Console.WriteLine();
            //    AccountState bank1 = AccountState.Active;
            //    Console.WriteLine(bank1);
            #endregion
            
            #region IAccount
            IAccount[] accounts = new IAccount[MAX_CUST];
            accounts[0] = new CustomerAccount();
            accounts[0].PayInFunds(50);
            Console.WriteLine("Balance: " + accounts[0].GetBalance());

            accounts[1] = new BabyAccount();
            accounts[1].PayInFunds(50);
            Console.WriteLine("Balance: " + accounts[1].GetBalance());

            if(accounts[0].WithdrawFunds(20))
            {
                Console.WriteLine("Withdraw OK");
            }

            if(accounts[1].WithdrawFunds(20))
            {
                Console.WriteLine("Withdraw OK");
            }
            else
            {
                Console.WriteLine("Transaction Failed");
            }
            #endregion
        }
    }
}