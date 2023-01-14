using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2015;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Senior Software Developer";
        job2._company = "Microsoft";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume resume = new Resume();
        resume._name = "Allison Rose";
        
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}