internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<char, int> uniqueCharacters = new Dictionary<char, int>();
        char[] charactersInString;
        string sentence;

        while(true)
        {
            Console.Write("Type a sentence to count how many times a character occurs : ");
            sentence = Console.ReadLine() ?? "";
            if (!String.IsNullOrWhiteSpace(sentence))
            {
                charactersInString = sentence.ToCharArray();
                break;
            }
        }

        for (var i = 0; i < charactersInString.Length; i++)
        {
            if (!uniqueCharacters.ContainsKey(charactersInString[i]))
                uniqueCharacters.Add(charactersInString[i], 1);
        }        

        // Counts instances for every unique char from original string
        for(var i = 0; i < uniqueCharacters.Count; i++)
        {
            KeyValuePair<char, int> kvp = uniqueCharacters.ElementAt(i);
            int freq = sentence.Split(kvp.Key).Length - 1;

            Console.WriteLine("the character {0} repeats {1} times.", kvp.Key, freq);
        }
    }
}