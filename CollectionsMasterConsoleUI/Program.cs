using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.ExceptionServices;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numbers = new int[50];


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);

            //TODO: Print the first number of the array
           
            Console.WriteLine($"{numbers[0]} is the first number of the array");
           
            //TODO: Print the last number of the array            
          
            Console.WriteLine($"{numbers[numbers.Length - 1]} is the last number of the array");
            
            Console.WriteLine("All Numbers Original");
            
            //UNCOMMENT this method to print out your numbers from arrays or lists
            
            NumberPrinter(numbers);
            
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Array.Reverse(numbers);

            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(numbers); 

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);
            NumberPrinter(numbers);
            Console.WriteLine(""); 


            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("");

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var list = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"List starting capacity: {list.Capacity}");


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(list);
            NumberPrinter(list);

            //TODO: Print the new capacity
            Console.WriteLine($"The new list capacity: {list.Capacity}"); 

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int searchNumber = int.Parse(Console.ReadLine()); 
            NumberChecker(list, searchNumber);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(list);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(list);
            NumberPrinter(list);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            list.Sort();
            NumberPrinter(list);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var arrayFromList = list.ToArray();

            //TODO: Clear the list
            list.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length;i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(x => x % 2 != 0);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool wasFound = false; 
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] == searchNumber)
                {
                    Console.WriteLine("The number has been found");
                    wasFound = true;
                    break;
                }
                
            }
            if (wasFound)
            {
                return;
            }
            Console.WriteLine("Number was not found"); 
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next());
            }
           
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            int index = 0;
            for (int i = array.Length -1; i>= 0;  i--) 
            {
                newArray[index] = array[i];
                index++;

            }
            NumberPrinter(newArray); 
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
