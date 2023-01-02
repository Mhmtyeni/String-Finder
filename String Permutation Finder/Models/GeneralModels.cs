using System.Collections.Generic;

namespace String_Permutation_Finder.Models
{
    class GeneralModels
    {
        public bool Exit { get; set; }
        public string InputText { get; set; }
        public string InputFindText { get; set; }
        public int Number { get; set; }
        public List<string> FirstText { get; set; }
        public List<string> FindText { get; set; }
        public List<string> TempFindedText { get; set; }
        public GeneralModels()
        {
            FirstText = new List<string>();
            FindText = new List<string>();
            TempFindedText = new List<string>();
        }
    }
}
