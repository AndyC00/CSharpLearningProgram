using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//delegate: a special type that can point to a method
//syntax: delegate <return type> <delegate name> (<type parameter>):
//delegate int MyDelegate(int a, int b);

//1. self-defined delegate:
SayDelegate d1 = SayHello;
SayDelegate d2 = SayGoodbye;

string msg = d1("AABABA");
Console.WriteLine(msg);

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
// Action: void return type
// Func: has return value
