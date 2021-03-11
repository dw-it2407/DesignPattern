using System;
using System.IO;

namespace Srp
{
    public class Persistence
    {      

        public static Journal Load(string fileName)
        {
            return new Journal();
        }

        public void Load(Uri uri)
        {

        }

        public void SaveToFile(Journal j, string fileName)
        {
            File.WriteAllText(fileName, j.ToString());
        }
    }
}
