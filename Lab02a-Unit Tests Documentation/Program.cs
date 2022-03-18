using System;

namespace Lab02a_Unit_Tests_Documentation
{
   public class Program
    {
         public static decimal balance = 0;

        static void Main(string[] args)
        {
            UserInterface();
        }

        //UserInterface
       
            public static void UserInterface()
        {
            try
            {
                Console.WriteLine("Welcome dear customer !");
                Console.WriteLine("Choose the banking process :");
                Console.WriteLine("View Balance : 1");
                Console.WriteLine("Withdraw : 2");
                Console.WriteLine("Deposit : 3");
                Console.WriteLine("EXIT :4");
                String action = Console.ReadLine();
                bool runATM = true;
                while (runATM == true)
                {
                    switch (action)
                    {
                        case "1":
                            Console.WriteLine("Your Balance : " + ViewBalance());
                            Console.WriteLine("If you want to do another process click the number !");
                            break;
                           
                        case "2":
                            Console.WriteLine("Please inter your withdraw");
                            decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Your balance after withdawing :" + Withdraw(withdraw));
                            Console.WriteLine("If you want to do another process click the number !");
                            break;
                        case "3":
                            Console.WriteLine("Please enter the deposit amount !");
                            decimal deposit = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Your balance after deposit :" + Deposit(deposit));
                            Console.WriteLine("If you want to do another process click the number !");
                            break;
                        case "4":
                            runATM = false;
                            Console.WriteLine("Do you want to exit ? (Yes/No)");

                            break;
                        default:
                            Console.WriteLine("Do you want to do another processes ? ");
                            break;
                    }
                    action = Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Thank you");
            }
        }





            //ViewBalance
             public static decimal ViewBalance()
             {
            return balance;
             }

        //Withdraw
        public static decimal Withdraw(decimal value)
         {
          
            if (value < 0)
            {
                Console.WriteLine("Please enter value greater than 0");
                return balance;
            }
            if (value > balance)
            {
                Console.WriteLine("Your balance is not enough for the withdrawal process");
                return balance;
            }
            else
            {
                balance -= value;
                return balance;
            }
        }

        //Deposit
        public static decimal Deposit(decimal value)
         {
            if (value < 0)
            {
                Console.WriteLine("This value is not allowed");
                return balance;
            }
            else
            {
                balance += value;
                return balance;
            }
        }

    }
}