using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        int looperVariable = 1;

        while (looperVariable>0)
        {
            List<int> baseNumberList = Program.numberEnter();
            Console.WriteLine("Do you want the list sorted?");
            string answer = Console.ReadLine();

            if(answer == "yes"){
                List<int> numberlistSorted = new List<int>(Program.sorter(baseNumberList));
                Console.WriteLine(numberlistSorted);
            }
            Program.math(baseNumberList);
            Console.WriteLine("Would you like to run another list?");

            answer = Console.ReadLine();

            if (answer == "no" ) { looperVariable = 0 ; }
        }
    }

    static List<int> numberEnter()
    {
        List<int> baseNumberList = new List<int>();
        Console.WriteLine("Enter numbers one at a time at promt, enter 0 when finished.");

        int A;
        do
        {
            Console.WriteLine("Enter a number: ");
            A = int.Parse(Console.ReadLine());
            baseNumberList.Add(A);

        } while (A != 0);

        Console.WriteLine($"total number of items in list: {baseNumberList.Count}");

        return baseNumberList;
    }
    
    static List<int> sorter(List<int> baseNumberList)
    {
        List<int> listsorted = new List<int>();
        int len = baseNumberList.Count();
        int i = 1;
        do
        {
            listsorted.Add(baseNumberList[i]);
            i += 1;
            len -= 1;
            
        }while(len>0);
        listsorted.Sort();
        return listsorted;
    }
    static void math(List<int> baseNumberList)
    {
        int sum = 0;
        int counter = 0;
        int largest = -10000;
        int smallest = 10000;

        for (int i = 0 ; i<baseNumberList.Count ; i++){
            sum += baseNumberList[i];
            counter += 1;

            if (baseNumberList[i]>largest){
                largest = baseNumberList[i];
            }

            if (baseNumberList[i]<smallest){
                smallest = baseNumberList[i];
            }
        }

        Console.WriteLine($"sum of list = {sum}");

        int avg = sum/n;

        Console.WriteLine($"List Average = {avg}");
        Console.WriteLine($"the largest number is {largest}");
        Console.WriteLine($"the smallest number is {smallest}");
    }
    
}