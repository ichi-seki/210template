using System;

class Program
{
    static void Main(string[] args)
    {
        System.Random random = new System.Random();

        Scripture scripture1 = new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding " + "In all thy ways acknowledge him and he shall direct thy paths");

        Scripture scripture2 = new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life");

        Scripture scripture3 = new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God");

        System.Collections.Generic.List<Scripture> scriptures = new System.Collections.Generic.List<Scripture>();
        scriptures.Add(scripture1);
        scriptures.Add(scripture2);
        scriptures.Add(scripture3);

        int randomIndex = random.Next(scriptures.Count);
        Scripture selectedScripture = scriptures[randomIndex];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.Display());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLower() == "quit")
            {
                break;
            }

            selectedScripture.hideThreeRandomWords(3);

            if (selectedScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(selectedScripture.Display());
                Console.WriteLine();
                Console.WriteLine("All the words are hidden. Program ends.");
                break;
                
            }
        }

        
    }
}