using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp.arrays___exercises
{
    class BankAccount
    {
        // Static variables to track all accounts and manage ID increment
        private static List<BankAccount> accounts = new List<BankAccount>();
        private static int idCounter = 1;
        private static double interestRate = 0.02; // Default interest rate

        // Private fields for the BankAccount
        private int id;
        private double balance;

        // Constructor to create a new BankAccount
        public BankAccount()
        {
            this.id = idCounter++;
            this.balance = 0;
            accounts.Add(this);
            Console.WriteLine($"Account ID{id} created");
        }

        // Static method to set the global interest rate
        public static void SetInterestRate(double interest)
        {
            interestRate = interest;
        }

        // Method to deposit an amount into the account
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount} to ID{id}");
        }

        // Method to calculate interest for a given number of years
        public double GetInterest(int years)
        {
            return balance * interestRate * years;
        }

        // Static method to find an account by ID
        public static BankAccount GetAccountById(int id)
        {
            return accounts.Find(account => account.id == id);
        }

        // Method to handle GetInterest command
        public static void HandleGetInterest(int id, int years)
        {
            var account = GetAccountById(id);
            if (account != null)
            {
                Console.WriteLine(account.GetInterest(years));
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        // Main method to handle input and commands
        public static void Run()
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                switch (action)
                {
                    case "Create":
                        new BankAccount(); // Create a new account
                        break;

                    case "Deposit":
                        int depositId = int.Parse(commandArgs[1]);
                        double amount = double.Parse(commandArgs[2]);
                        var account = GetAccountById(depositId);
                        if (account != null)
                        {
                            account.Deposit(amount); // Deposit into the specified account
                        }
                        else
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        break;

                    case "SetInterest":
                        double interestRate = double.Parse(commandArgs[1]);
                        SetInterestRate(interestRate); // Set global interest rate
                        break;

                    case "GetInterest":
                        int id = int.Parse(commandArgs[1]);
                        int years = int.Parse(commandArgs[2]);
                        HandleGetInterest(id, years); // Get interest for the account
                        break;

                    case "End":
                        return;

                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }   }
            }
        }
    }
