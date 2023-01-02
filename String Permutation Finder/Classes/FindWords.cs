using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Permutation_Finder.Classes
{
    public static class FindWords
    {
        public static void FindWord(List<string> firstList, List<string> findedList)
        {
            for (int z = 0; z < findedList.Count(); z++){
                for (int v = 0; v < firstList.Count(); v++)
                {
                    int position = firstList[v].Select(o => findedList[z].IndexOf(o))
                        .OrderBy(i => i).FirstOrDefault(i => i != -1);
                    Console.WriteLine(position);
                }
            }
           

        }
    }
}

