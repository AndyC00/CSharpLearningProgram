using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class RandomClass
{
    //delegate: a special type that can point to a method
    //syntax: delegate <return type> <delegate name> (<type parameter>):
    //delegate int MyDelegate(int a, int b);

    //1. self-defined delegate:
    SayDelegate d1 = SayHello;
    SayDelegate d2 = SayGoodbye;
    public void say()
    {
        string msg = d1("AABABA");
        Console.WriteLine(msg);
    }
    static string SayHello(string name)
    {
        return $"Hello {name}";
    }
    static string SayGoodbye(string name)
    {
        return $"Goodbye {name}";
    }

    delegate string SayDelegate(string msg);


    //2. pre-defined delegate: Func, Action
    // Func: has return value
    // Func syntax: Func<parameter type, return type> (can have multiple parameters here, the last one will be the return type)

    public static Func<string, string> fn = SayHello;

    //3. Anonymous Delegate:
    // syntax: delegate (type parameter) {code block}
    public static 
    Func<string, string> fn2 = delegate (string name)
    {
        return $"Hey Hey Hey {name}";
    };
    //when taking multiple parameters:
    public static
    Func<int, int, string> fn3 = delegate (int a, int b)
    {
        return $"the sum of the two number {a} + {b} is {a + b}";
    };
    // Action: void return type
    public static
    Action<string> act = delegate (string name)
    {
        Console.WriteLine ($"Hey Hey Hey {name}");
    };

    //4. Lambda Expression:
    // Lambda is a concise way to represent an anonymous delegate
    // syntax: (input parameters) => expression
    // => calls "goes to"
    public static
    Func<int, int, string> fn4 = (i, j) =>  //the type of i and j is inferred from the context, can be omitted
    {
        return $"the sum of the two number {i} + {j} is {i + j}";
    };  //this is the same as fn3

    //if the expression is simple, the braces{} and return can be omitted
    public static
    Func<int, int, string> fn5 = (i, j) => $"the sum of the two number {i} + {j} is {i + j}";

    //if the expression has no return value and only one line of statement, the braces{} can be omitted:
    public static
    Action<int, int> fn6 = (i, j) => Console.WriteLine($"the sum of the two number {i} + {j} is {i + j}");

    //if there's only one parameter, the parentheses() can be omitted:
    public static
    Action<int> fn7 = i => Console.WriteLine($"the number is {i}");

    //if there's no parameter, the parameters taking can be omitted:
    public static
    Action fn8 = () => Console.WriteLine("blablabla");

}

// define a function to filter all numbers bigger than 10 from the array:
class Practice
{
    static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 40, 50, 60, 70, 80, 90, 100 };
    static List<int> Filter(int[] nums, Func<int, bool> fn)
    { 
        List<int> result = new List<int>();
        foreach (int i in nums)
        {
            if (fn(i))
            { 
                result.Add(i);
            }
        }
        return result;
    }
    List<int> result = Filter(numbers, n => n > 10);
}