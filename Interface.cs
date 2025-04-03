using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProgram
{
    public interface ISaver
    {
        void Save();
    }

    public class FileSaver : ISaver
    {
        public void Save()
        {
            Console.WriteLine("File saved.");
        }
    }

    public class DatabaseSaver : ISaver
    {
        public void Save()
        {
            Console.WriteLine("Data saved to database.");
        }
    }

    public class CloudSaver : ISaver
    {
        public void Save()
        {
            Console.WriteLine("Data saved to cloud.");
        }
    }

    public class SaveManager
    { 
        public void SaveData(ISaver saver)
        {
            saver.Save();
        }
    }
}

