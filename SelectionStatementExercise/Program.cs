}
using Internal;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var favNumber = 555;
            int userInput;

            do
            {

                Console.WriteLine("Try and guess the number from 1 to 1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput > favNumber)
                {
                    Console.WriteLine("nope, Too high!");

                }

                else if (userInput < favNumber)
                {
                    Console.WriteLine("Almost, But to low!");
                }

                else
                {
                    Console.WriteLine("CORRECT!!!");
                }


            } while (userInput != favNumber);

        }

    }
}