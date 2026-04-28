using System;
namespace EncapsulationDemo
{
    public class Bank
    {
        
        private double balance;


        public double GetBalance()
        {
                        
            return balance;
        }

        public void SetBalance(double balance)
        {
      
            this.balance = balance;
        }
    }
    class Encapsulation_Prog1
    {
        public static void Main(String[]args)
        {
            Bank bank = new Bank();
     
            bank.SetBalance(500);
            Console.WriteLine(bank.GetBalance());
            Console.ReadKey();
        }
    }
}
