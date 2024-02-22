namespace Topic_5___Making_an_new_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            double betChoice;
            int diceSum;
            

            Console.WriteLine("Welcome to my dice game!");
            Console.WriteLine();
            Console.WriteLine("In this game you will bet on the probable of two die.");
            Console.WriteLine();
            Console.WriteLine("Here are your options:");
            Console.WriteLine();
            Console.WriteLine("1. Doubles - Dice roll doubles, you win double your bet.");
            Console.WriteLine();
            Console.WriteLine("2. Not doubles - Dice doesnt roll doubles, you win half your bet.");
            Console.WriteLine();
            Console.WriteLine("3. Even sum - Dice total is an even sum, you win your bet.");
            Console.WriteLine();
            Console.WriteLine("4. Odd sum - Dice total is an odd sum, win your bet.");
            Console.WriteLine();
            Console.WriteLine("Please type your number below:");
            Console.WriteLine();
            betChoice = Convert.ToInt32(Console.ReadLine());

            Die die1 = new Die();
            Die die2 = new Die();
            Console.WriteLine();
            Console.WriteLine("Here is your roll:");
            
            die1.DrawRoll();
            die2.DrawRoll();

            if (die1 == die2)
            {

            }
            else if (die1 != die2)
            {

            }
            else if (die1 % 2 == 0) 
            {

            }

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