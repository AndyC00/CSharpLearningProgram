using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningProgram
{
    public interface IUser
    {
        public string Name {get; set; }

        public int Age {get; set; }

        public void aMethod();
    }
}