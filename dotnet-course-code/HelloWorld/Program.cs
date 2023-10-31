using System;

namespace HelloWorld // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 34};

          DateTime startTime = DateTime.Now;
            
            int totalValue = intsToCompress[0] + intsToCompress[1] + intsToCompress[2] + intsToCompress[3] + intsToCompress[4] + intsToCompress[5] + intsToCompress[6];
            Console.WriteLine(totalValue);

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            //146

            totalValue = 0;

            startTime = DateTime.Now;

            for (int i = 0; i < intsToCompress.Length; i++)
            {
                totalValue += intsToCompress[i];
                
            }

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine(totalValue);

            //ForEach

            totalValue = 0;
            startTime = DateTime.Now;
            foreach (int i in intsToCompress)
            {
                totalValue += i;
            }
            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);

            //While

            totalValue = 0;
            startTime = DateTime.Now;
            int index = 0;

            while(index < intsToCompress.Length)
            {
                totalValue += intsToCompress[index];
                index++;
            }

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);

            //Do While

            totalValue = 0;
            startTime = DateTime.Now;
            index = 0;

            do
            {
                totalValue += intsToCompress[index];
                index++;
            }
            while (index < intsToCompress.Length);
            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);

            foreach(int i in intsToCompress)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            startTime = DateTime.Now;
            totalValue = 0;
            totalValue = GetSum(intsToCompress);
            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);

            int[] intsToCompress2 = new int[] {23, 23, 53, 56, 83, 92};

            totalValue = GetSum(intsToCompress2);
            Console.WriteLine(totalValue);
        }

        static private int GetSum(int[] intsToCompress)
        {
            //int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 34};
            int totalValue = 0;
            foreach (int intForCompression in intsToCompress)
            {
                totalValue += intForCompression;
            }
            return totalValue;
        }
    }
}