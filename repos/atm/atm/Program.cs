using System;
using System.Collections.Generic;
using System.Linq;

public class carduser
{
    string card_num;
    int pin;
    string fname;
    string lname;
    double balance;

    public carduser(string card_num, int pin, string fname, string lname, double balance)
    {
        this.card_num = card_num;
        this.pin = pin;
        this.fname = fname;
        this.lname = lname;
        this.balance = balance;
    }

    public string getNum()
    {
        return card_num;
    }

    public int getPin()
    {
        return pin;
    }

    public string getFname()
    {
        return fname;
    }

    public string getLname()
    {
        return lname;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setNum(string newCardNum)
    {
        card_num = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFname(string newFirstname)
    {
        fname = newFirstname;
    }

    public void setLname(string newLastname)
    {
        lname = newLastname;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void options()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            
        }
        void Deposit(carduser currentuser)
        {
            Console.WriteLine("How much would you like to deposit? ");
            double deposit = double.Parse(Console.ReadLine());
            currentuser.setBalance(currentuser.getBalance() + deposit);
            Console.WriteLine("Thank you for your deposit. your new balance is: " + currentuser.getBalance() + "NGN");

        }
        void Withdraw(carduser currentuser)
        {
            Console.WriteLine("How much would you like to withdraw? ");
            double withdrawal = double.Parse(Console.ReadLine());
            //check if he/she has enough money to withdraw
            if (currentuser.getBalance() > withdrawal)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Console.WriteLine("you withdrew" + withdrawal + "NGN");
                currentuser.setBalance(currentuser.getBalance() - withdrawal);
                Console.WriteLine("You're good to go...");
            }

        }
        void Balance(carduser currentuser)
        {
            Console.WriteLine("current balance is: " + currentuser.getBalance());
        }

        List<carduser> cardusers = new List<carduser>();
        cardusers.Add(new carduser("2345678998765432", 2345, "Bruno", "Asika", 20000.34));
        cardusers.Add(new carduser("2345678998567489", 7890, "Adanna", "Ned", 200000.14));
        cardusers.Add(new carduser("4747788998765432", 4537, "Michael", "Okpala", 56000000.30));
        cardusers.Add(new carduser("2345675748835432", 1289, "John", "Wesley", 3400000000.12));
        cardusers.Add(new carduser("2345127374765432", 7326, "James", "Charles", 23000004.56));

        //prompt user
        Console.WriteLine("Welcome to my ATM services");
        Console.WriteLine("Please enter your debit card: ");
        String debitcardnum = "";
        carduser currentUser;

        while(true)
        {
            try
            {
                debitcardnum = Console.ReadLine();
                //check against our db
                currentUser = cardusers.FirstOrDefault(a => a.card_num == debitcardnum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card not recognized. Please try again"); }
            }
            catch { Console.WriteLine("Card not recognized. Please try again"); }
        }

        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect pin. Please try again"); }
            }
            catch { Console.WriteLine("Incorrect pin. Please try again"); }
        }

        Console.WriteLine("Welcome " + currentUser.getFname() + " :)");
        int option = 0;
        do
        {
            options();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1) { Deposit(currentUser); }
            else if (option == 2) { Withdraw(currentUser); }
            else if (option == 3) { Balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank you for using my atm");
    }
}