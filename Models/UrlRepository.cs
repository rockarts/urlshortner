using System.Collections.Generic;

public class UrlRepository : IRepository
{
    private static Dictionary<int, string> database = new Dictionary<int, string>();

    public int Add(string longUrl)
    {
        // [1, http://reddit.com]
        int key = database.Count + 1;
        database.Add(key, longUrl);
        return key;
    }

    public string Get(int key)
    {
        return database[key];
    }
}