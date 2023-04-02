namespace _8Ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Run infinitely until user closes program
            while (true)
            {
                // Get random number between 0 and 4
                Random rng = new Random();
                int randomNumber = rng.Next(0, 4);

                // Have user ask question
                Console.Write("Ask the 8-Ball a yes or no question: ");
                Console.ReadLine();

                // Have the 8-Ball answer the question
                Console.Write("Answer: ");
                switch(randomNumber)
                {
                    case 0:
                        Console.Write("Yes.\n");
                        break;
                    case 1:
                        Console.Write("No.\n");
                        break;
                    case 2:
                        Console.Write("Maybe.\n");
                        break;
                    case 3:
                        Console.Write("Try again later.\n");
                        break;
                    default:
                        // Random number must be 4
                        Console.Write(";)\n");
                        break;
                }
            }
        }
    }
}