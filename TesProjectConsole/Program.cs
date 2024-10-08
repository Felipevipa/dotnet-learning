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



// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");

// measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");


// price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// Console.WriteLine(yourDiscount);

// price = 67.55m;
// salePrice = 59.99m;

// yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);


// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12));
// Console.WriteLine(input.PadRight(12));
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));



// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));



// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }



// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

decimal number = 123.456879m;

Console.WriteLine(string.Format("{0:F2}", number));
Console.WriteLine(number.ToString("F2"));

int x = 10;
int y = 3;
int result = x % y;

Console.WriteLine(result);

if (x != 0) {
    Console.WriteLine((!(true && false)));
}

int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int num in numbers) {
    Console.WriteLine(num);
}

public int MultiplyNumbers(int num1, int num2) {
    return num1 * num2;
}

Console.WriteLine(MultiplyNumbers(3,4));