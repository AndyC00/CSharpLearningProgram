using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
    //enum:
        int x = (int)Days.Sunday;
        int y = (int)Days.Friday;
        Console.WriteLine("Sun = {0}",x);
        Console.WriteLine("Fri = {0}",y);
        Console.WriteLine("\n");

    //class:
        Person someone = new Person();
        someone.ID = 1;
        someone.Name = "Lily";
        someone.Age = 20;

        string msg = "Do you want to hire me?";
        string judge = "superman";
        someone.Say(judge, msg);

        Console.WriteLine("\n");

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

        Console.WriteLine("\n");

    //Interface:
        IUser player1 = new user();
        player1.Name = "A random user 001";
        player1.Age = 100;
        player1.aMethod();

        Console.WriteLine("\n");

    //a simple calculator:
    Console.WriteLine("Please enter 2 integers and a operator");
    Console.WriteLine("Press ‘“’Enter‘”’ to input the next character");

    float a = Convert.ToSingle(Console.ReadLine());
    float b = Convert.ToSingle(Console.ReadLine());
    string op = Convert.ToString(Console.ReadLine());

    switch (op)
    {
        case "+":
            Console.WriteLine("The result is " + (a+b));
            break;
        case "-":
            Console.WriteLine("The result is " + (a-b));
            break;
        case "*":
            Console.WriteLine("The result is " + (a*b));
            break;
        case "/":
            if(b==0)
            {
                Console.WriteLine("Error! The denominator can not be 0");
            }
            else
            {
                Console.WriteLine("The result is " + (a/b));
            }
            break;
        case "%":
            Console.WriteLine("The result is " + (a%b));
            break;
        default:
            break;
    }

    Console.ReadLine();
    }
}