using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        List<Job> jobs = new List<Job>();

        do{

            Job job = new Job();
            Console.WriteLine("insert job title: ");
            job._jobTitle = Console.ReadLine();
            Console.WriteLine("insert company name: ");
            job._company = Console.ReadLine();
            Console.WriteLine("insert final year of work: ");
            job._endYear = int.Parse(Console.ReadLine());
            Console.WriteLine("insert initial year of work: ");
            job._startYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you wish to enter a new job experience?");

        } while (Console.ReadLine() == "yes");

        Console.WriteLine("type zero for list all jobs, or type a number for a specific job");

        int countJobs = jobs.count();
        int listAnswer = int.Parse(Console.ReadLine());

        if (listAnswer == 0){

            for(i = 0; i <= countJobs; i ++)
            {
                Console.WriteLine($"title: {job(i)._jobTitle}\nCompany: {job(i)._company}\nstarting year: {job(i)._startYear}\nEnd Year: {job[i]._endYear}");
                job(i).Display();
            }
        }
        else if (listAnswer > 0)
        {
            Job selectedJob = jobs[listAnswer - 1];
        }
        else{
            if (listAnswer > countJobs) { Console.WriteLine("invalid entry");}
            else
            {
                Console.WriteLine($"title: {job(listAnswer)._jobTitle}\nCompany: {job(listAnswer)._company}\nstarting year: {job(listAnswer)._startYear}\nEnd Year: {job(listAnswer)._endYear}");
            }
        }

    }
}