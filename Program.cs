using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using LearningProgram;
using System.Collections;
using System.Collections.Generic;
using System.Timers;

class Aprogram
{
    //enum:
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
        //list & arraylist:
        someLists myList = new someLists();
        Console.WriteLine(myList.list01[0]);
        Console.WriteLine(myList.list01[7]);
        myList.list01.Add("The 8th element");
        Console.WriteLine(myList.list01[8]);
        int count = myList.list01.Count;
        Console.WriteLine("There are " + count + " elements in this list");
        myList.list01.RemoveAt(1);
        myList.list01.Remove(5);
        myList.list01.Insert(1, "the second element");

        int count2 = myList.list02.Count;
        Console.WriteLine("The second list has " + count2 + " elements");

        //loop:
        foreach (var element in myList.list01)
        {
            Console.Write(element);
            Console.Write(" ");
        }
        Console.WriteLine(" ");

        foreach (object item in myList.list02)
        {
            Console.Write(item);
            Console.Write(" ");
        }
        Console.Write("\n");

        //sorting the list:
        List<float> listFloat = new List<float>();
        for (int i = 0; i < count2; i++)
        {
            if (myList.list02[i] is int)
            {
                listFloat.Add((float)(int)myList.list02[i]);
            }
            else if (myList.list02[i] is float)
            {
                listFloat.Add((float)myList.list02[i]);
            }
        }
        listFloat.Sort();
        foreach (float item in listFloat)
        {
            Console.Write(item + " ");
        }

        //enum:
        int x = (int)Days.Sunday;
        int y = (int)Days.Friday;
        Console.WriteLine("Sun = {0}", x);
        Console.WriteLine("Fri = {0}", y);
        Console.WriteLine("\n");

        //class:
        Person someone = new Person();
        someone.ID = 1;
        someone.Name = "Lily";
        someone.Age = 20;

        string msg = "Do you want to hire me?";
        string judge = "superman";
        someone.Say(judge, msg);

        Console.Write("\n");

        //sub-class:
        Student stu1 = new Student();
        stu1.Name = "Micheal";
        stu1.Age = 16;
        stu1.ID = 2;
        stu1.Major = "Math";
        stu1.Study();
        string University = "AUT";
        stu1.Study(University);
        stu1.Study("UoA");
        stu1.Say("Batman", "Are you clown?");

        Console.WriteLine(" ");

        //Interface:
        IUser player1 = new User();
        player1.Name = "A random user 001";
        player1.Age = 100;
        player1.aMethod();

        Console.WriteLine(" ");

        //Dictionary:
        Dictionary<string, object> Dic01 = new Dictionary<string, object>();
        Dic01.Add("1st episode", "nothing here");
        Dic01.Add("2nd episode", 45);
        Dic01.Add("3rd episode", true);
        Console.WriteLine(Dic01["1st episode"]);

        //structure:
        Magazine magazine1; //creating struct does not need keyword "new"
        magazine1.title = "World of Natual";
        magazine1.year = 2019;
        magazine1.publishingYear = 2010;
        magazine1.author = "me";
        magazine1.published = true;
        int time = magazine1.HowLong(magazine1.year, magazine1.publishingYear);
        Console.WriteLine("The magazine has published for " + time + " years");

        //reference:
        int num1 = 55, num2 = 100;
        char op = '%';
        Calculator.Run(ref num1, op, ref num2);
        Console.WriteLine(" of calculating " + num1 + " " + op + " " + num2);

        //run the simple calculator:
        Calculator.Run();

        //event: A 2s timer:
        EventTimer timer = new EventTimer(2000);
        TimerHandler handler = new TimerHandler();

        timer.Elapsed += handler.OnTimerElapsed;

        timer.Start();
        Console.WriteLine("The 2s timer has start!\nPress any key to exit.");
        Console.ReadKey();
        timer.Stop();

        //from lambda.cs:
        RandomClass random = new RandomClass();

        random.say();
        Console.WriteLine(RandomClass.fn("Andy"));
        Console.WriteLine(RandomClass.fn2("Jamie"));
        Console.WriteLine(RandomClass.fn3(4, 5));
        Console.WriteLine(RandomClass.act);

        //avoid the report
        Console.ReadLine();
    }
}