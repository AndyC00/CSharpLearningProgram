using System;
using System.Data;
using LearningProgram;

class Program
{
    enum Days
    {
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
    }

    static void Main(string[] arg)
    {
        int x = (int)Days.Sunday;
        int y = (int)Days.Friday;
        Console.WriteLine("Sun = {0}",x);
        Console.WriteLine("Fri = {0}",y);

        Person someone = new Person();
        someone.ID = 1;
        someone.Name = "Lily";
        someone.Age = 20;

        string msg = "Do you want to hire me?";
        string judge = "superman";
        someone.Say(judge, msg);

        Student stu1 = new Student();
        stu1.Name = "Micheal";
        stu1.Age = 16;
        stu1.ID = 2;
        stu1.Major = "Math";
        stu1.Study();

    Console.ReadLine();
    }
}