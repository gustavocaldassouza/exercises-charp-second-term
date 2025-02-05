namespace WorkspaceCsharp
{
    public class ExerciseNineAThree
    {
        public static void Exec()
        {
            Console.WriteLine("Enter a character, a digit, or a special character: ");
            char input = Convert.ToChar(Console.ReadLine());

            if (Char.IsLetter(input))
            {
                Console.WriteLine("You entered a letter.");
            }
            else if (Char.IsDigit(input))
            {
                Console.WriteLine("You entered a digit.");
            }
            else
            {
                Console.WriteLine("You entered a special character.");
            }
        }
    }
}
