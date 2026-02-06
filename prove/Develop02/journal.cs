using System.IO; 
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void Write()
    {
        Entry entry = new Entry();
        entry._prompt = _prompts[Random.Shared.Next(_prompts.Count)];
        Console.WriteLine(entry._prompt);
        DateTime currentTime = DateTime.Now;
        entry._date = currentTime.ToShortDateString();
        entry._text = Console.ReadLine();
        _entries.Add(entry);
    }
    public void DisplayE()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Load()
    {
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
        }
    }
    public void Save()
    {
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_entries);
        }
    }

    public void Delete()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            Console.WriteLine("Which records do you want to delete? ");
            Console.WriteLine($"{i + 1}. {_entries[i]}");
            string remove = Console.ReadLine();
            if (int.TryParse(remove, out int number))
            {
                int index = number - 1;

                if (index >= 0 && index < _entries.Count)
                {
                    _entries.RemoveAt(index);
                    Console.WriteLine("Deleted.");  
                } else
                {
                    Console.WriteLine("No such number.");
                }
            }
        }
    }
    public void Quit(){}
}