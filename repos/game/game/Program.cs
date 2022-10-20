using System;


namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("..........WELCOME TO MY SIMPLE QUIZ GAME..........");
            start:
            Console.WriteLine("do you want to play the game? Yes OR No");
            string ans = (Console.ReadLine());
            
            if (ans == "Yes")
            {
                Console.WriteLine("Okay, Let us begin...");
                string[] answer = { "A", "D", "B", "c", "A" };
                string answer1;
                string answer2;
                string answer3;
                string answer4;
                string answer5;
                int point = 0;

                Console.WriteLine("1. what barks?");
                Console.WriteLine("A. a dog   B. a fish   C. a cat    D. a goat");
                answer1 = (Console.ReadLine());
                if (answer1 == answer[0])
                {
                    point += 1;
                    Console.WriteLine("you are correct");
                }
                else
                {
                    
                    Console.WriteLine("you are wrong");
                }
                Console.WriteLine("2. what bleats?");
                Console.WriteLine("A. a dog   B. a fish   C. a cat    D. a goat");
                answer2 = (Console.ReadLine());
                if (answer2 == answer[1])
                {
                    point += 1;
                    Console.WriteLine("you are correct");
                }
                else
                {
                    
                    Console.WriteLine("you are wrong");
                }
                Console.WriteLine("3. what lives under water?");
                Console.WriteLine("A. a dog   B. a fish   C. a cat    D. a goat");
                answer3 = (Console.ReadLine());
                if (answer3 == answer[2])
                {
                    point += 1;
                    Console.WriteLine("you are correct");
                }
                else
                {
                    
                    Console.WriteLine("you are wrong");
                }
                Console.WriteLine("4. what meows and drinks milk?");
                Console.WriteLine("A. a dog   B. a fish   C. a cat    D. a goat");
                answer4 = (Console.ReadLine());
                if (answer4 == answer[3])
                {
                    point += 1;
                    Console.WriteLine("you are correct");
                }
                else
                {
                    
                    Console.WriteLine("you are wrong");
                }
                Console.WriteLine("5. what is the king of the jungle?");
                Console.WriteLine("A. a lion   B. a fish   C. a cat    D. a goat");
                answer5 = (Console.ReadLine());
                if (answer5 == answer[4])
                {
                    point += 1;
                    Console.WriteLine("you are correct");
                }
                else
                {
                    
                    Console.WriteLine("you are wrong");
                }
                Console.WriteLine("your name is:  " + name);
                Console.WriteLine("your total score is:  " + point);
                Console.ReadLine();
            }
            else if(ans == "No")
            {
                Console.WriteLine("Thank you for exiting, if you would like to play press yes");
                Console.ReadLine();
                goto start;
            }
            else
            {
                Console.WriteLine("Please answer within yes or no");
                goto start;

            }

            


        }
    }
}
