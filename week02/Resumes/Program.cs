using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Google";
        job1._startYear = 2025;
        job1._endYear = 2027;

        Job job2 = new Job();
        job2._jobTitle = "Engineer";
        job2._companyName = "Tesla";
        job2._startYear = 2025;
        job2._endYear = 2028;
        //Console.WriteLine(job1._companyName);
        //Console.WriteLine(job2._companyName);
        //job1.Display();
        //job2.Display();

        Resumes resume1 = new Resumes();
        resume1._name = "Gabrielly";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();





    }
}