using String_Permutation_Finder.Models;
using System.Collections.Generic;

namespace String_Permutation_Finder.Classes
{
    public class Permutations
    {
        private GeneralModels generalModels = new GeneralModels();

        public List<string> Permutation(bool isClear, char[] arr, int left, int right)
        {
            if (isClear)
            {
                generalModels.TempFindedText.Clear();
                isClear = false;
            }
            if (left == right)
            {
                generalModels.Number++;
                generalModels.TempFindedText.Add(new string(arr));
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    ChangedTexts.ChangedText(ref arr[left], ref arr[i]);
                    Permutation(isClear, arr, left + 1, right);
                    ChangedTexts.ChangedText(ref arr[left], ref arr[i]);
                }
            }
            return generalModels.TempFindedText;
        }

    }

}
