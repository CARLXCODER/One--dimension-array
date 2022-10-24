using System;

namespace carl;

class Program  
    {  
        static void Main(string[] args)  
        {  
            int[] array = { 12,25,43,43,43 };  
            Console.WriteLine("Your Array...");  
            for (int i = 0; i < array.Length; i++)  
            {  
                Console.Write(array[i] + " ");  
            }  
            Console.WriteLine("\n\n");  
            Console.Write("Enter a number to search:  ");  
            int number = Convert.ToInt32(Console.ReadLine());  
            int occurrences = array.Count(x => x == number);  
            Console.WriteLine(" {0} occurs {1} times", number, occurrences);  
            Console.ReadKey();  
        }  
    }  
