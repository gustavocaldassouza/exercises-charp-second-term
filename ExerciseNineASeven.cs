namespace WorkspaceCsharp
{
    public class ExerciseNineASeven
    {
        public static void Exec()
        {
            int[] id = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < id.Length - 1; i++)
            {
                for (int j = i + 1; j < id.Length - 1; j++)
                {
                    if (id[j] > id[j + 1])
                    {
                        Swap(ref id[j], ref id[j + 1]);
                    }
                }
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
