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



// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] ids = orderStream.Split(",");
// Array.Sort(ids);

// for (int i = 0; i < ids.Length; i++)
// {
//     Console.Write(ids[i]);
//     if (ids[i].Length != 4)
//         Console.Write("\t - Error");
//     Console.WriteLine();
// }



string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");


price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);

price = 67.55m;
salePrice = 59.99m;

yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);


string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));