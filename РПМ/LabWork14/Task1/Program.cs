using System.Text.RegularExpressions;

string input = "+7(900)918-79-65";
string pattern = @"^(\+7|8)\(\d{3}\)\d{3}(-\d{2}){2}$";
Regex regex = new(pattern);
if (!regex.IsMatch(input))
    Console.WriteLine("Некоректный номер");
else
    Console.WriteLine("Номер существует");

