public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string promptText, string entryText)
    {
         _date = new DateTime().ToString();
         _promptText = promptText ;
         _entryText = entryText;
    }
    public void Display()
    {

    }
}