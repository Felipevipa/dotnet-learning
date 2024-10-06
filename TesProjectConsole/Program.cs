// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] words = pangram.Split(' ');

// for (int i = 0; i < words.Length; i++)
// {
//     // Console.WriteLine(word);
//     char[] letters = words[i].ToCharArray();
//     Array.Reverse(letters);
//     string reversedWord = new string(letters);
//     words[i] = reversedWord;
//     // Console.WriteLine(reversedWord);
// }

// string reversedPangram = string.Join(" ", words);

// Console.WriteLine(reversedPangram);



string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] ids = orderStream.Split(",");
Array.Sort(ids);

for (int i = 0; i < ids.Length; i++)
{
    Console.Write(ids[i]);
    if (ids[i].Length != 4)
        Console.Write("\t - Error");
    Console.WriteLine();
}