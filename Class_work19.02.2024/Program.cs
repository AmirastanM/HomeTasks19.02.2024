//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//stringBuilder str = new stringBuilder("Salam");
//str.Append("sagol");


//int age = 100;
//Console.WriteLine(age.ToString().GetType());


//using System.Security.Cryptography.X509Certificates;

//string surname = "test";

//Console.WriteLine(surname.Length);


//string str1 = "salam";
//string str2 = "necesiz ?";

//string result = string.Concat(str1, str2);

//Console.WriteLine(result);


//string result = "";

//string result2 = string.Empty;

//var result3 = result2 + "salam";



//string text = string.Empty;

//if (string.IsNullOrEmpty(text))
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine("fill");
//}


//string text = string.Empty;

//if (string.IsNullOrWhiteSpace(text))
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine("fill");
//}

//string text = "Azerbaijan";

//Console.WriteLine(text.ToUpper());

//Console.WriteLine(text.ToLower());

//Console.WriteLine("Apple" == "apple");

//string str1 = "    Apple";
//string str2 = "apple";

//Console.WriteLine(str1.Trim().ToLower() == str2.Trim().ToLower());

//Console.WriteLine(str1.Trim().ToLower().Equals(str2.Trim().ToLower()));

//Console.WriteLine(CheckStr(str1).Equals(CheckStr(str2)));

//string CheckStr(string str)
//{
//    return str.Trim().ToLower();
//}


//string str = "this is the \"Salam\" class.";

//Console.WriteLine(str);

//string message = $"Welcome to {str}";
//string text = "Azerbaijan";

//Console.WriteLine(string.Format(text));

//string authors = "Mahesh Chand, Herry He, Chris Love, Raj Beniwal, Praveen Kumar";

//Console.WriteLine(authors);

//string[] authorsList = authors.Split(", ");

//foreach (string item in authorsList)
//{
//    Console.WriteLine(item);
//}


//string text = "Salam Azerbaijan";

//Console.WriteLine(text.Replace("Salam", "sagol"));

//Console.WriteLine(text.Substring(3));

//Console.WriteLine(text.Substring(0, 5));

//string result = text.Substring(0, 5) + "...";

//Console.WriteLine(result);


//Console.WriteLine(text.Contains("Az"));


//string text = "Salam Azerbaijan";

//Console.WriteLine(CheckCharInStr("Baku", "B"));



//bool Search(string text, string letter)
//{
//    return CheckStr(text).Contains(CheckStr(letter));
//}

//string CheckStr(string str)
//{
//    return str.Trim().ToLower();
//}

//void StartSearch()
//{
//    Console.WriteLine("Add text:");
//    string text = Console.ReadLine();

//    Console.WriteLine("Add search text:");
//    string searchText = Console.ReadLine();

//    if (Search(text, searchText))
//    {
//        Console.WriteLine("Found");
//    }
//    else
//    {
//        Console.WriteLine("Not Found");
//    }
//}

//StartSearch();