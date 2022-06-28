using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Example dictionary.
        var dictionary = new Dictionary<string, int>(5);
        dictionary.Add("cat", 1);
        dictionary.Add("dog", 0);
        dictionary.Add("mouse", 5);
        dictionary.Add("eel", 3);
        dictionary.Add("programmer", 2);

        // Order by values.
        // ... Use LINQ to specify sorting by value.
        var items = from pair in dictionary
                orderby pair.Value ascending
                select pair;

        // Display results.
        foreach (KeyValuePair<string, int> pair in items)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }

        // Reverse sort.
        // ... Can be looped over in the same way as above.
        items = from pair in dictionary
        orderby pair.Value descending
        select pair;
    }
}