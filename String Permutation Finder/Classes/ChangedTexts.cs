namespace String_Permutation_Finder.Classes
{
    public static class ChangedTexts
    {
        public static void ChangedText(ref char a, ref char b)
        {
            if (a == b) return;
            char c = a;
            a = b;
            b = c;
        }
    }
}
