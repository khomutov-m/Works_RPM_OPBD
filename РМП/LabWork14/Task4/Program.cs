using System.Text.RegularExpressions;

string pattern = @"(?=.*[?!.])(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.{6,})";
Regex regex = new(pattern);
string input;
do
{
    Console.WriteLine("Введите пароль:");
    input = Console.ReadLine();
} while (!regex.IsMatch(input));
