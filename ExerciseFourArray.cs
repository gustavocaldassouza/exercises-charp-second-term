using InterfaceImplementationLister;
using Spectre.Console;

namespace ExerciseCSharp;

public class ExerciseFourArray : IExerciseInterface
{
    public void Execute()
    {
        while (true)
        {
            AnsiConsole.Write(
                new FigletText("Guess what I am saying!").LeftJustified().Color(Color.Green)
            );
            string secretMessage = AnsiConsole.Prompt(
                new TextPrompt<string>("Input what Klara said?")
            );
            if (secretMessage != string.Empty)
            {
                for (int i = 0; i < 3; i++)
                {
                    AnsiConsole.Write(
                        new Rule($"{i + 1} attempt").LeftJustified().RuleStyle("red")
                    );
                    string input = AnsiConsole.Prompt(new TextPrompt<string>("What Klara said?"));
                    if (input == string.Empty)
                    {
                        Console.WriteLine("You didn't say anything!");
                        break;
                    }
                    if (input.ToLower() == secretMessage.ToLower())
                    {
                        Console.WriteLine("You got it!");
                        break;
                    }
                }
                if (!AnsiConsole.Confirm("You want to play again?"))
                {
                    return;
                }
                Console.Clear();
            }
            else
            {
                Console.WriteLine("You didn't say anything!");
            }
        }
    }
}

