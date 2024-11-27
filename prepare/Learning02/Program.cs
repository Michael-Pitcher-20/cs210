using System;

class Program

{
    static void Main(string[] args)
    {
        Job jobOne = new Job();
        jobOne._jobTitle = "Barista";
        jobOne._company = "Panera Bread";
        jobOne._startYear = 2018;
        jobOne._endYear = 2019;

        Job jobTwo = new Job();
        jobTwo._jobTitle = "Large Scale Events Coordinator";
        jobTwo._company = " BYUI";
        jobTwo._startYear = 2023;
        jobTwo._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Michael Pitcher";

        myResume._jobs.Add(jobOne);
        myResume._jobs.Add(jobTwo);

        myResume.Display();

    }

}
