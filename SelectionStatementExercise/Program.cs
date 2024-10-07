namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var r = new Random();

            int favNumber = 5;

            Console.WriteLine("Try and guess the number from 1 to 1000");
            int userInput = Console.ReadLine();

            if(userInput > favNumber)
            {
                Console.Writeline("nope, Too high!");

            }
            if else(userInput < favNumber)
            {
                Console.WriteLine("Almost, But to low!");
            }
            else(userInput == favNumber)
            {
                Console.WriteLine("CORRECT!!!");
            }



            
        }
    }
}
