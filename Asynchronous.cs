using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProgram
{
    class Asynchronous
    {
        Action fn = () => Parallel.For(0, 10, i => Console.WriteLine(i));
    }
}
