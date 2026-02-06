using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using Microsoft.VisualBasic.FileIO;

class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();
        List<string> commands = new List<string>{"Write", "Display", "Load", "Save", "Delete", "Quit"};

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        for (int i = 0; i < commands.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {commands[i]}");
        }
        Console.WriteLine("What would you like to do? ");
        string action = Console.ReadLine();
        if (action == "1"){
            journal.Write();
        }
        else if (action == "2")
        {
            journal.DisplayE();
        }
        else if (action == "3")
        {
            journal.Load();
        }
        else if (action == "4")
        {
            journal.Save();
        }
        else if (action == "5")
        {
            journal.Delete();
        }
        else {}

        // Entry entry = new Entry();
        // entry._date = "2026/1/28";
        // entry._text = "Hello";
        // entry._prompt = "a";
        // entry.Display();
    }
}