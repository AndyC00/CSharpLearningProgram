using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningProgram;

class Calculator
{
    public static void Run(ref int a, char op, ref int b)
    {
        switch (op)
        {
        case '+':
            Console.WriteLine("The result is " + (a+b));
            break;
        case '-':
            Console.WriteLine("The result is " + (a-b));
            break;
        case '*':
            Console.WriteLine("The result is " + (a*b));
            break;
        case '/':
            if(b==0)
            {
                Console.WriteLine("Error! The denominator can not be 0");
            }
            else
            {
                Console.WriteLine("The result is " + (a/b));
            }
            break;
        case '%':
            Console.WriteLine("The result is " + (a%b));
            break;
        default:
            break;
        }
    }

    //Method overloading
    public static void Run()
    {
    //a simple calculator:
    Console.WriteLine("Please enter 2 integers and a operator");
    Console.WriteLine("Press “Enter” to input the next character");

    float a = Convert.ToSingle(Console.ReadLine());
    float b = Convert.ToSingle(Console.ReadLine());
    string op = Convert.ToString(Console.ReadLine()) ?? "";

    //switch:
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

    }
}