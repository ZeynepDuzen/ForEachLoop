using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] sehirler = {"Tekirdag","Istanbul","Bursa"};
            //foreach (string sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}

            // ****************************************************************** 
            //    string[] words = {"Computer","tea","book","cellphone","sticker"};

            //    Console.WriteLine("Please write a word");
            //    string searchWord = Console.ReadLine();
            //    Search(searchWord,words);

            // ******************************************************************
            int[] numbers = new int[5]
            { 5,
              3,
              9,
              6,
              2,
            };

            Console.WriteLine("Please enter a number between 1-10");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            SearchNum(searchNumber,numbers);


            Console.Read();
            //}
            //static void Search(string searchWord, string[] words)
            //{
            //    bool found = false;
            //    foreach (string word in words)
            //    {
            //        if (searchWord == word)
            //        {
            //            found = true;
            //            break;
            //        }
            //    }
            //    if (found)
            //    {
            //        Console.WriteLine(searchWord + " is found");
            //    }
            //    else
            //    {
            //        Console.WriteLine(searchWord + " is not found");
            //    }
        }
        static void SearchNum(int searchNumber, int[] numbers)
        {
            bool found = false;
            foreach (int number in numbers)
            {
                if (searchNumber == number)
                {
                    found = true;
                    break;
                }
               
            }
            if (found)
            {
                Console.WriteLine(searchNumber + " is found");
            }
            else
            {
                Console.WriteLine(searchNumber + " is not found");
            }
        }
    }
}
