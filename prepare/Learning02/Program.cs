/* 
Class: Job
Attributes:
* _jobTitle : string
* _CompanyName : string
* _startYear : int
* _endYear : int

Behaviors:
* DisplayInfo() : void
---  ---  ---  ---  ---  --- 
Class: Resume
Attributes:
* _name : string
* _jobs : List<job>

Behaviors:
* DisplayResume() : void
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Digital Curator";
        job1._CompanyName = "Discord";
        job1._startYear = 2014;
        job1._endYear = 2019;

        Job realJob = new Job();
        realJob._jobTitle = "Dishwasher";
        realJob._CompanyName = "HopeWorks Soup Kitchen";
        realJob._startYear = 2018;
        realJob._endYear = 2018;

        Resume myResume = new Resume();
        myResume._name = "Pubert Johnson";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(realJob);
        myResume.Display();
    }
}