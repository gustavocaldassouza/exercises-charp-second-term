using System.Reflection;
using Spectre.Console;

namespace InterfaceImplementationLister
{
    class Program
    {
        static void Main(string[] args)
        {
            var interfaceType = typeof(IExerciseInterface);
            var implementingTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => interfaceType.IsAssignableFrom(t) && t.IsClass && !t.IsAbstract)
                .ToList();

            // Display the list of classes using Spectre.Console
            var table = new Table();
            table.AddColumn("Index");
            table.AddColumn("Exercise");

            for (int i = 0; i < implementingTypes.Count; i++)
            {
                table.AddRow((i + 1).ToString(), implementingTypes[i].Name);
            }

            AnsiConsole.Write(table);

            // Let the user choose which class to execute
            var choice = AnsiConsole.Ask<int>(
                "Enter the [yellow]number[/] of the exercise you want to execute:"
            );

            if (choice > 0 && choice <= implementingTypes.Count)
            {
                var selectedType = implementingTypes[choice - 1];

                // Execute the chosen class's method
                var instance = Activator.CreateInstance(selectedType) as IExerciseInterface;
                instance?.Execute();
            }
            else
            {
                AnsiConsole.MarkupLine("[red]Invalid choice.[/]");
            }
        }
    }
}
