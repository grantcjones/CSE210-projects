public class Journal
{   

    Entry _userEntry = new Entry();
    // IDictionary<int, string> _myDict = new Dictionary<int, string>();

    // public List<string> _ = new List<string>();
    
    
    public List<string> _entries = new List<string>();

    public void Save()
    {

    }

    public List<string> AddEntry()
    {
        {
            string userEntry = _userEntry.GetEntry();
            _entries.Add(userEntry);
            return _entries;
        }
    }

    public void Display()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(_entries);
        }
    }

}
