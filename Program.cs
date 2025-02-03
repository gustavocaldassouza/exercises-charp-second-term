using System.Reflection;
using Spectre.Console;

namespace InterfaceImplementationLister
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.Clear();
                    var interfaceType = typeof(IExerciseInterface);
                    var implementingTypes = Assembly
                        .GetExecutingAssembly()
                        .GetTypes()
                        .Where(t => interfaceType.IsAssignableFrom(t) && t.IsClass && !t.IsAbstract)
                        .ToList();

                    var selectionPrompt = new SelectionPrompt<string>()
                        .Title("Select a class to execute:")
                        .PageSize(10)
                        .AddChoices(implementingTypes.Select(t => t.Name).Append("Exit"));

                    var selectedClassName = AnsiConsole.Prompt(selectionPrompt);

                    if (selectedClassName == "Exit")
                    {
                        AnsiConsole
                            .Status()
                            .Start(
                                "Exiting...",
                                ctx =>
                                {
                                    Thread.Sleep(1000);
                                }
                            );
                        break;
                    }
                    else
                    {
                        var selectedType = implementingTypes.FirstOrDefault(t =>
                            t.Name == selectedClassName
                        );
                        if (selectedType != null)
                        {
                            var instance =
                                Activator.CreateInstance(selectedType) as IExerciseInterface;
                            instance?.Execute();
                            AnsiConsole.MarkupLine(
                                "\n[green]Press any key to return to the main menu.[/]"
                            );
                            Console.ReadLine();
                        }
                        else
                        {
                            AnsiConsole.MarkupLine("[red]Invalid choice.[/]");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AnsiConsole.MarkupLine($"[red]{ex.Message}[/]");
            }
        }
    }
}
