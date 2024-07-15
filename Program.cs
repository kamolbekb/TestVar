namespace TestVar;
internal class Program
{
    public static void Main(string[] args)
    {
        #region
        //Console.Write("Enter the text: ");
        //string str = Console.ReadLine();
        //int count = 0;
        //int size = 0;
        //for (int i = 0; i < str.Length; i++)
        //{
        //    if (Char.IsLetter(str[i]))
        //    {
        //        count++;
        //    }
        //    else
        //    {
        //        if (count > size)
        //        {
        //            size = count;
        //        }
        //        count = 0;
        //    }
        //}
        //Console.WriteLine($"The size of longest word in a text:{size}");
        #endregion

        #region
        //Console.Write("Enter size of array: ");
        //int[] arr = new int[int.Parse(Console.ReadLine())];
        //for(int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write($"Array [{i}] = ");
        //    arr[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine();

        //for(int i = 0; i < arr.Length; i++)
        //{
        //    for(int j = i+1; j < arr.Length-1; j++)
        //    {
        //        if (arr[i] > arr[j])
        //        {
        //            int l = arr[i];
        //            arr[i] = arr[j];
        //            arr[j] = l;
        //        }
        //    }
        //}


        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine($"Array [{i}] = {arr[i]}");
        //}
        #endregion

        //task 3
        /*
        Console.Write("Enter size of array: ");
        int[] arr = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Array [{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        int result = FindLeastFrequentNumber(arr);
        Console.WriteLine($"Arraydagi eng kam takrorlangan raqam bu {result}");
        */

        //4 task

        Console.Write("Enter the text: ");
        string str = Console.ReadLine();
        int count = 0;
        char mostUsedLetter = TheMostUsedLetter(str);

        Console.WriteLine($"The size of longest word in a text:{mostUsedLetter}");

    }

    static char TheMostUsedLetter(string s)
    {
        int count = 0;
        char mostUsed = '\0';

        for (int i = 0; i < s.Length; i++)
        {
            char currentChar = Char.ToLower(s[i]);

            if (!Char.IsLetter(currentChar))
            {
                continue;
            }

            int inCount = 1;

            for (int j = i + 1; j < s.Length; j++)
            {
                if (Char.ToLower(s[j]) == currentChar)
                {
                    inCount++;
                }
            }

            if (inCount > count)
            {
                count = inCount;
                mostUsed = currentChar;
            }
        }

        return mostUsed;
    }


    static int FindLeastFrequentNumber(int[] arr)
    {
        int leastFrequentNumber = arr[0];
        int minFrequency = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            int currentNumber = arr[i];
            int frequency = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == currentNumber)
                {
                    frequency++;
                }
            }

            if (frequency < minFrequency)
            {
                minFrequency = frequency;
                leastFrequentNumber = currentNumber;
            }

        }

        return leastFrequentNumber;
    }
}
