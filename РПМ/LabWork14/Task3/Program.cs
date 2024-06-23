using System.Text.RegularExpressions;

string input = "dOg@gmail.ru";
string pattern = @"(\w+|-)@\w+\.[a-z]{2,}(\.\w)*";
Regex regex = new(pattern, RegexOptions.IgnoreCase);
if (!regex.IsMatch(input))
    Console.WriteLine("Некоректный e-mail адрес");
