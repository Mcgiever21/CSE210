using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        int a=1;
        while (a>0)
        {
            List<int> ListA = Program.numberEnter();
            Console.WriteLine("Do you want the list sorted?");
            string answer = Console.ReadLine();
            if(answer == "yes"){
                List<int> listSorted = new List<int>(Program.sorter(listA));
            }
            Program.math(listA);
            Console.WriteLine("Would you like to run another list?");
            string B = Console.ReadLine();
            if (B=="no"){a=0;}
        }
    }

    static List<int> numberEnter()
    {
        List<int> listA = new List<int>();
        Console.WriteLine("Enter numbers one at a time at promt, enter 0 when finished.");
        int A;
        do
        {
            Console.WriteLine("Enter a number: ");
            A = int.Parse(Console.ReadLine());
            listA.Add(A);

        } while (A!=0);
        Console.WriteLine($"total number of items in list: {listA.Count}");
        return listA;
    }
    
    static List<int> sorter(List<int> listA)
    {
        List<int> listC = new List<int>();
        int len = listA.Count();
        do
        {
            for (int i = 0; i < listA.Count; i++){
                listC.Add(listA(i));
            }
        }while(len>0);
        listC.Sort();
        return listC;
    }
    static void math(List<int> listA)
    {
        int sum=0;
        int n=0;
        int largest=-10000;
        int smallest=10000;
        for (int i=0;i<listA.Count;i++){
            sum =+listA(i);
            n=+1;
            if (listA(i)>largest){
                largest=listA(i);
            }
            if (listA(i)<smallest){
                smallest=listA(i);
            }
        }
        Console.WriteLine($"sum of list = {sum}");
        int avg = sum/n;
        Console.WriteLine($"List Average = {avg}");
        Console.WriteLine($"the largest number is {largest}");
        Console.WriteLine($"the smallest number is {smallest}");
        return;
    }
    
}