using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Collections;


namespace LearningProgram
{
    public class Person
    {
        public int ID {get; set; }
        public string Name {get; set; }
        public int Age {get; set;}

        //methods
        public void Say(string judge, string msg)
        {
            Console.WriteLine("hello, I am {0}", Name);
            Console.WriteLine($"I am a {judge}");
            Console.WriteLine(msg);
        }
    }

    public class Student: Person
    {
        public string Major {get; set; }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying {Major}");
        }

        public void Study(string aaa)
        {
            Console.WriteLine($"{Name} is studying {Major} at {aaa}");
        }
    }

    public class user : IUser
        {
        public string Name {get; set; }

        public int Age {get; set; }

            public void aMethod()
            {
                Console.WriteLine($"{Name} has joined the chat");
            }
        }
    
    public class someLists
    {
        public ArrayList list01 = new ArrayList()
        {
            1,2,3,4,5,6,true,"yeah"
        };

    //creating a list using struct:
        public List<object> list02;
        public someLists()
        {
            list02 = new List<object>()
            {
                4.1, 5.2, 7, 10, "interesting", true, false, 1, 0, 1000, 99, 120, 111,
            };
        }
    }
}