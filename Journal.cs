public class Journal
{
    public List<Entry>_entries = new();

    public void  AddEntry()
    {
       string prompt  = PromptGenerator.GetRandomPrompt();
       Console.WriteLine(prompt);
       Console.Write("Write the text of your entry as single string");
       Console.ReadLine();
       string entryText = Console.ReadLine();

       Entry entry = new(prompt, entryText);
       


    }

    public void display()
    {
    
    }
    public void SaveToFile(string  file)
    {

    }
    public void  LoadFromFile(string file)
    {

    }
}