using InterfaceImplementationLister;

namespace WorkspaceCsharp;

public class WeatherEight : IExerciseInterface
{
    public void Execute()
    {
        //Console.WriteLine(Console.ReadLine());
        int month,
            day;
        do
        {
            Console.WriteLine("Enter a month (1-12) and a day (1-31): ");
            month = Convert.ToInt32(Console.ReadLine());
            day = Convert.ToInt32(Console.ReadLine());
        } while (month < 1 || month > 12 || day < 1 || day > 31);

        // invalid month == T && invalid day ==T
        // invalid month == F && invalid day ==T  // feb/2 day=40
        // invalid month == T && invalid day ==F // month =13 day = 1

        // valid = month >=1 && month <=12
        // while (!valid)
        // !(month >=1 && month <=12 ) --> month <1 || month > 12
        //-infinity  .... [[1 ... 12]] .... +infinity[


        //Console.WriteLine("Enter the Day: ");

        //int day = Convert.ToInt32(Console.ReadLine());

        if (month == 12 && day >= 21 || month <= 3 && day <= 20)
        {
            Console.WriteLine("Winter");
        }
        else if (month == 3 && day >= 21 || month <= 6 && day <= 20)
        {
            Console.WriteLine("Spring");
        }
        else if (month == 6 && day >= 21 || month <= 9 && day <= 20)
        {
            Console.WriteLine("Summer");
        }
        else if (month == 9 && day >= 21 || month <= 12 && day <= 20)
        {
            Console.WriteLine("Autumn");
        }
    }
}
