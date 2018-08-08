using System;
using System.Collections.Generic;
using System.IO;

namespace DesignPatterns.SOLID
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}. {text}");
            return count; //memento pattern
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }


    }
    /// <summary>
    /// concern: saving persistence
    /// </summary>
    public class Persistance
    {
        public void Save(Journal journal, string filename, bool overwrite = false)
        {
            if(overwrite || !File.Exists(filename))
               File.WriteAllText(filename, journal.ToString());     
        }

        public static Journal Load(Uri uri)
        {
            return null;
        }        
    }

    public class SRunner
    {
        public void Run() 
        {
             var journal = new DesignPatterns.SOLID.Journal();
            journal.AddEntry("I wrote code today");
            journal.AddEntry("I drank coffee today");
            Console.WriteLine(journal);
        }
    }

}
