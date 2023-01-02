using String_Permutation_Finder.Classes;
using String_Permutation_Finder.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace String_Permutation_Finder
{

    class Program
    {
        static void Main(string[] args)
        {

            var str1 = "MehmetYeni";
            var str2 = "mhmtyen";

            var common = str1.Intersect(str2);

            foreach (var c in common)
                Console.WriteLine(c); // "i", "r", "e"
        }
    }
}