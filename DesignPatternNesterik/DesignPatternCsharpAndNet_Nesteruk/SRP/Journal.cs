using System;
using System.Collections.Generic;
using System.IO;

namespace Srp
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{ ++count}: {text}");
            return count;//memento
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        /// <summary>
        /// Violates SRP
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="j"></param>
        public void SaveFile(string fileName, Journal j)
        {

        }

        /// <summary>
        /// violates SRP
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public Journal LoadFile(string fileName)
        {
            return new Journal();

        }

    }
}
