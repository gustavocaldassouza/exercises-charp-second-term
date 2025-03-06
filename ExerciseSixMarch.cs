using System.Collections;
using InterfaceImplementationLister;

class ExerciseSixMarch : IExerciseInterface
{
    public void Execute()
    {
        Console.WriteLine(MyTools.NumToAlphaMonth(3));
        Console.WriteLine(MyTools.GetDayOfTheWeek(5, 3, 2024));
    }

    public static class MyTools
    {
        public static string NumToAlphaMonth(int month)
        {
            string[] months =
            {
                "Jan",
                "Feb",
                "Mar",
                "Apr",
                "May",
                "Jun",
                "Jul",
                "Aug",
                "Sep",
                "Oct",
                "Nov",
                "Dec",
            };
            return (month >= 1 && month <= 12) ? months[month - 1] : "Invalid Month";
        }

        public static string GetDayOfTheWeek(int d, int m, int y)
        {
            DateTime date = new DateTime(y, m, d);
            return date.ToString("ddd");
        }

        public static bool Contains(int[] theArray, int searchKey)
        {
            return Array.Exists(theArray, element => element == searchKey);

            // old way
            foreach (int element in theArray)
            {
                if (element == searchKey)
                    return true;
            }
        }

        public static bool Contains(ArrayList theArray, int searchKey)
        {
            return theArray.Contains(searchKey);

            // old way
            foreach (int element in theArray)
            {
                if (element == searchKey)
                    return true;
            }
        }

        public static bool Contains(List<int> theArray, int searchKey)
        {
            return theArray.Contains(searchKey);

            // old way
            foreach (int element in theArray)
            {
                if (element == searchKey)
                    return true;
            }
        }

        public static bool IsIdentical(int[] arrayA, int[] arrayB)
        {
            if (arrayA.Length != arrayB.Length)
                return false;
            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] != arrayB[i])
                    return false;
            }
            return true;
        }

        public static bool IsIdentical(string strA, string strB)
        {
            return strA.Equals(strB);
        }
    }

    public class Date
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get => day;
            set => day = value;
        }
        public int Month
        {
            get => month;
            set => month = value;
        }
        public int Year
        {
            get => year;
            set => year = value;
        }

        public Date()
        {
            day = 1;
            month = 1;
            year = 2025;
        }

        public Date(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
        }

        public string DisplayEUShortDate()
        {
            return $"{day}/{month}/{year}";
        }

        public string DisplayUSShortDate()
        {
            return $"{month}/{day}/{year}";
        }

        public string DisplayLongDate()
        {
            return $"{GetMonthName()} {day}, {year}";
        }

        public string DisplayFullDate()
        {
            return $"{GetDayOfTheWeek()}, {GetMonthName()} {day}, {year}";
        }

        private string GetMonthName()
        {
            return new DateTime(year, month, day).ToString("MMMM");
        }

        private string GetDayOfTheWeek()
        {
            return new DateTime(year, month, day).ToString("dddd");
        }

        public override string ToString()
        {
            return $"{day}-{month}-{year}";
        }
    }
}
