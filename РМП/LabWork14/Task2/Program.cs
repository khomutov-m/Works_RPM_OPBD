using System.Text.RegularExpressions;

string input = "hello    world  hello world";
string pattern = @" {2,}";
Regex regex = new(pattern);
input = regex.Replace(input, " ");
Console.WriteLine(input);
