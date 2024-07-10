using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningProgram
{
    public struct Magazine
    {
        public string title;
        public string author;
        public int year;
        public int publishingYear;
        public bool published;

        public int HowLong(int year, int publishingYear)
        {
            return year - publishingYear;
        }
    }
}