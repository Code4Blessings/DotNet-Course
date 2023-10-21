using System;

namespace HelloWorld // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int myInt = 5;

          Console.WriteLine(myInt);
          int mySecondInt = 10;

          myInt++;

          Console.WriteLine(myInt);
        
            myInt += 7;
          Console.WriteLine(myInt);

            myInt -= 8;
            Console.WriteLine(myInt);

            Console.WriteLine(myInt * mySecondInt);

            Console.WriteLine(mySecondInt / myInt);

            //Exponents

            Console.WriteLine(Math.Pow(5, 2));

            //Square root

            Console.WriteLine(Math.Sqrt(25));

            //Use operators to change the value of strings

            string myString = "Test";

            Console.WriteLine(myString);

            myString += "ing";

            Console.WriteLine(myString);

            myString = myString + " \"third part.\"";

            Console.WriteLine(myString);

            //Splitting strings

            string[] myStringArray = myString.Split(". ");
            
            Console.WriteLine(myStringArray[0]);
            Console.WriteLine(myStringArray[1]);
            Console.WriteLine(myStringArray[2]);
            
        }
    }
}