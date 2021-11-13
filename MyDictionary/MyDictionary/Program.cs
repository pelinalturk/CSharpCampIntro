using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> nameAndId = new Dictionary<int, string> ();
            nameAndId.Add(0, "Pelin");
            nameAndId.Add(1, "Engin");

            _MyDictionary<int, string> s = new _MyDictionary<int, string>();
            s.Add(1, "");
            s.Add(1, "");
            Console.WriteLine(s.Count());
        }
    }
}
