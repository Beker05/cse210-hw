using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Google", "Data Analyst", 2022, 2024);

        Resume myResume = new Resume("Beker Cubillas");
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        myResume.DisplayResume();
    }
}