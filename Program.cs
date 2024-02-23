namespace Topic_5___Making_an_new_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            double betChoice, userBet, account;
            account = 100;
            

            Console.WriteLine("Welcome to my dice game!");
            Console.WriteLine();
            Console.WriteLine($"In this game you will bet on the probable of two die. Your account balence is ${account}");
            Console.WriteLine();
            Console.WriteLine("Here are your options:");
            Console.WriteLine();
            Console.WriteLine("1. Doubles - Dice roll doubles, you win double your bet. Dice don't roll doubles, you lose double your bet.");
            Console.WriteLine();
            Console.WriteLine("2. Not doubles - Dice doesnt roll doubles, you win half your bet. Dice roll doubles, you lose half your bet.");
            Console.WriteLine();
            Console.WriteLine("3. Even sum - Dice total is an even sum, you win your bet. Dice total is an odd sum, you lose your bet.");
            Console.WriteLine();
            Console.WriteLine("4. Odd sum - Dice total is an odd sum, win your bet. Dice total is an even sum you lose your bet.");
            Console.WriteLine();
            Console.WriteLine("Please type your number below:");
            Console.WriteLine();
            betChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease type the amount you'd lke to bet below:");
            Console.WriteLine();
            userBet = Convert.ToInt32(Console.ReadLine());
            if (userBet > account)
            {
                Console.WriteLine($"You bet more than your account balence. Your bet is now ${account}");
                userBet = account;
            }
            else if (userBet < 0)
            {
                Console.WriteLine("That is an invalied bet. \n\nPlease type a new bet below:");
                userBet = Convert.ToInt32(Console.ReadLine()) ;
            }

            Die die1 = new Die();
            Die die2 = new Die();
            Console.WriteLine();
            Console.WriteLine("Here is your roll:");
            
            die1.DrawRoll();
            die2.DrawRoll();

            if (die1 == die2)//.roll
            {
                DisplayBets(betChoice);

                void DisplayBets(double betChoice)
                {
                    switch (betChoice)
                    {
                        case (1):
                            Console.WriteLine("doubles");
                            Console.WriteLine("Thats correct, the dice rolled doubles! \n\nYour bet has been doubled and added to your sum!");
                            account = (userBet * 2) + account;
                            Console.WriteLine($"Account Balence: {account}");
                            break;
                        default:
                            Console.WriteLine("doubles");
                            Console.WriteLine("That's incorrect.\n\nDouble your bet has been removed from your sum.");
                            account = account - (userBet * 2);
                            Console.WriteLine($"Account Balence: {account}");
                            break;
                    }
                }
            }
            else if (die1 != die2)
            {
                DisplayBets(betChoice);

                void DisplayBets(double betChoice)
                {
                    switch (betChoice)
                    {
                        case (2):
                            Console.WriteLine("not doubles");
                            Console.WriteLine("Thats correct, the dice did not roll doubles! \n\nYou win half your bet!");
                            account = (userBet / 2) + account;
                            Console.WriteLine($"Account Balence: {account}");
                            break;
                        default:
                            Console.WriteLine("not doubles");
                            Console.WriteLine("That's incorrect.\n\nYou lose half your bet.");
                            account = account - (userBet / 2);
                            Console.WriteLine($"Account Balence: {account}");
                            break;
                    }
                }
            }
            else if ((die1.Roll + die2.Roll) % 2  == 0)
            {
                DisplayBets(betChoice);

                void DisplayBets(double betChoice)
                {
                    switch (betChoice)
                    {
                        case (3):
                            Console.WriteLine("even");
                            Console.WriteLine("Thats correct, the dice sum is even! \n\nYou win your bet!");
                            account = userBet + account;
                            Console.WriteLine($"Account Balence: {account}");
                            break;
                        default:
                            Console.WriteLine("even");
                            Console.WriteLine("That's incorrect.\n\nYou lose your bet.");
                            account = account - userBet;
                            Console.WriteLine($"Account Balence: {account}");
                            break;
                    }
                }
            }
            else if ((die1.Roll + die2.Roll) % 2 != 0)
            {
                DisplayBets(betChoice);

                void DisplayBets(double betChoice)
                {
                    switch (betChoice)
                    {
                        case (4):
                            Console.WriteLine("odd");
                            Console.WriteLine("Thats correct, the dice sum is odd! \n\nYou win your bet!");
                            account = userBet + account;
                            Console.WriteLine($"Account Balence: {account}");
                            break;
                        default:
                            Console.WriteLine("odd");
                            Console.WriteLine("That's incorrect.\n\nYou lose your bet.");
                            account = account - userBet;
                            Console.WriteLine($"Account Balence: {account}");
                            break;
                    }
                }
            }
            
            //hi:3
            /*
            DisplayBets(betChoice);

            void DisplayBets(double betChoice)
            {
                switch(betChoice)
                {
                    case (1): //Doubles
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case (2): //Not Doubles
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case (3): //Even sum
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case (4)://odd sum
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                }
            }*/


        }
    }
}