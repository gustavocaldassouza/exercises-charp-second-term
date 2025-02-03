namespace InterfaceImplementationLister;

class ExerciseThreeArray : IExerciseInterface
{
    void IExerciseInterface.Execute()
    {
        Console.WriteLine("Exercise Three: Array");
        Console.WriteLine("Enter the number of elements in the array:");

        int n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Invalid number of elements.");
            return;
        }

        int[] a = new int[n];
        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < n; i++)
        {
            a[i] = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
        }

        int[] b = new int[n + 1];
        b[0] = a[0];
        b[n] = a[n - 1];

        for (int i = 1; i < n; i++)
        {
            b[i] = a[i] + a[i - 1];
        }

        Console.WriteLine("The b array is:");
        foreach (int i in b)
        {
            Console.Write(i + " ");
        }
    }
}
