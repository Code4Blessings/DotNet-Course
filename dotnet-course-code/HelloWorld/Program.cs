﻿using System;

namespace HelloWorld // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //// 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows
            // //// Each bit can be worth 0 or 1 of the value it is placed in
            // ////// From the right we start with a value of 1 and double for each digit to the left
            // //// 00000000 = 0
            // //// 00000001 = 1
            // //// 00000010 = 2
            // //// 00000011 = 3
            // //// 00000100 = 4
            // //// 00000101 = 5
            // //// 00000110 = 6
            // //// 00000111 = 7
            // //// 00001000 = 8
 
            // 1 byte (8 bit) unsigned, where signed means it can be negative
            // byte myByte = 255;
            // byte mySecondByte = 0;
 
            // // 1 byte (8 bit) signed, where signed means it can be negative
            // sbyte mySbyte = 127;
            // sbyte mySecondSbyte = -128;
 
 
            // 2 byte (16 bit) unsigned, where signed means it can be negative
            // ushort myUshort = 65535;
 
            // // 2 byte (16 bit) signed, where signed means it can be negative
            // short myShort = -32768;
 
            // // 4 byte (32 bit) signed, where signed means it can be negative
            // int myInt = 2147483647;
            // int mySecondInt = -2147483648;
 
            // // 8 byte (64 bit) signed, where signed means it can be negative
            // long myLong = -9223372036854775808;
 
 
            // 4 byte (32 bit) floating point number
            float myFloat = 0.751f;
            float mySecondFloat = 0.75f;
 
            // 8 byte (64 bit) floating point number
            double myDouble = 0.751;
            double mySecondDouble = 0.75d;
 
            // 16 byte (128 bit) floating point number
            decimal myDecimal = 0.751m;
            decimal mySecondDecimal = 0.75m;
 
            Console.WriteLine(myFloat - mySecondFloat);
            Console.WriteLine(myDouble - mySecondDouble);
            Console.WriteLine(myDecimal - mySecondDecimal);
 
 
 
            // string myString = "Hello World";
            // // Console.WriteLine(myString);
            // string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
            // // Console.WriteLine(myStringWithSymbols);
 
           // bool myBool = true;

            //DataStructures

            //Arrays

            //Defined amount of values for the array
            string[] myGroceryArray = new string[2];

            myGroceryArray[0] = "Guacamole";
            myGroceryArray[1] = "Ice Cream";

            Console.WriteLine(myGroceryArray[0]);
            Console.WriteLine(myGroceryArray[1]);
            //Console.WriteLine(myGroceryArray[2]);

            //However many values you put in the curly braces is how many values you can store in the array
            string[] mySecondGroceryArray = {"Apples", "Oranges"};

            // Console.WriteLine(mySecondGroceryArray[0]);
            // Console.WriteLine(mySecondGroceryArray[1]);

            //Lists - No given size needed

            List<string> myGroceryList = new List<string>(){"Milk", "Cheese"};

            // Console.WriteLine(myGroceryList[0]);
            // Console.WriteLine(myGroceryList[1]);

            myGroceryList.Add("Bread");
            
            // Console.WriteLine(myGroceryList[2]);

            //IEnumerable - Will be faster in the case of loops

            IEnumerable<string> myGroceryIEnumerable = myGroceryList; //Not an indexable collection but you can use the following syntax to get the index value

            Console.WriteLine(myGroceryIEnumerable.First());

            string[,] myTwoDimensionalArray = new string[,] {
                {"Apples", "Oranges"}, 
                {"Milk", "Cheese"}
            
            };

            Console.WriteLine(myTwoDimensionalArray[1,1]);

            //Dictionary - Key Value Pairs

            Dictionary<string, string> myGroceryDictionary = new Dictionary<string, string>(){
                {"Apples", "Fruit"}, //We're getting the department for each given value. In this case, Apples are the item and Fruit is the department
                {"Oranges", "Fruit"},
                {"Milk", "Dairy"}
            };
            //For the key of Milk, we're getting the value of Dairy
            Console.WriteLine(myGroceryDictionary["Milk"]);

            //You can also have an array inside our dictionary
            Dictionary<string, string[]> mySecondGroceryDictionary = new Dictionary<string, string[]>(){
                {"Fruit", new string[]{"Apples", "Oranges"}},
                {"Dairy", new string[]{"Milk", "Cheese"}}
            };
            Console.WriteLine(mySecondGroceryDictionary["Fruit"][0]);

            Dictionary<string, decimal> myThirdGroceryDictionary = new Dictionary<string, decimal>(){
                {"Apples", 0.99m},
                {"Oranges", 0.99m},
                {"Milk", 2.99m}
            };
        }
    }
}