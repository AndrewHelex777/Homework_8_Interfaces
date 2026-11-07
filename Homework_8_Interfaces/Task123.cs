namespace Homework_8_Interfaces
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }
    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
    interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }
    interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
    class Array : IOutput, IMath, ISort, ICalc, IOutput2, ICalc2
    {
        private int[] arr;
        public Array(int size)
        {
            arr = new int[size];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 25);
            }
        }
        public void Show()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }
        public void Show(string info)
        {
            Console.WriteLine(info);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }
        public int Max()
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public int Min()
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public float Avg()
        {
            float avg;
            float s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }
            avg = s / arr.Length;
            return avg;
        }
        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }
        public void SortAsc()
        {
            int t; bool flag;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                flag = true;
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        t = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = t;
                        flag = false;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
        }
        public void SortDesc()
        {
            int t; bool flag;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                flag = true;
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] > arr[j - 1])
                    {
                        t = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = t;
                        flag = false;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
        public int Less(int valueToSearch)
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (valueToSearch > arr[i])
                {
                    c++;
                }
            }
            return c;
        }
        public int Greater(int valueToSearch)
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (valueToSearch < arr[i])
                {
                    c++;
                }
            }
            return c;
        }
        public void ShowEven()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write($"{arr[i]}\t");
                }
            }
            Console.WriteLine();
        }
        public void ShowOdd()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write($"{arr[i]}\t");
                }
            }
            Console.WriteLine();
        }
        public int CountDistinct()
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    c++;
                }
            }
            return c;
        }
        public int EqualToValue(int valueToCompare)
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valueToCompare)
                {
                    c++;
                }
            }
            return c;
        }
    }
    internal class Task123
    {
        static void Main(string[] args)
        {
            Array arr = new Array(5);
            arr.Show("Array:");

            //arr.SortAsc();
            //arr.Show("Sorted ascending array:");
            //arr.SortDesc();
            //arr.Show("Sorted descending array:");
            //arr.SortByParam(true);
            //arr.Show("SortByParam(true):");
            //arr.SortByParam(false);
            //arr.Show("SortByParam(false):");

            Console.WriteLine($"Numbers count that less than 15: {arr.Less(15)}");
            Console.WriteLine($"Numbers count that greater than 15: {arr.Greater(15)}");

            Console.WriteLine("Even numbers:");
            arr.ShowEven();
            Console.WriteLine("\nOdd numbers:");
            arr.ShowOdd();

            Console.WriteLine($"Unique numbers: {arr.CountDistinct()}");
            Console.WriteLine($"Numbers that equal 5: {arr.EqualToValue(5)}");
        }
    }
}
