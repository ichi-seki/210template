using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Backend Developer";
        job2._company = "Amazon";
        job2._startYear = 2024;
        job2._endYear = 2025;

        Resume theResume = new Resume();
        theResume._name = "John Rock";
        theResume._job.Add(job1);
        theResume._job.Add(job2);

        theResume.Display();
    }
}