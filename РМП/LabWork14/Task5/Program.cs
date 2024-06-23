using System.Text.RegularExpressions;

string input = "2/11/2000";
string pattern = @"(?<days>\d{1,2})(\.|/)(?<months>\d{1,2})(\.|/)(?<years>\d{4}|\d{2})+";
Regex regex = new(pattern);
input = regex.Replace(input, "${years}-${months}-${days}");
Console.WriteLine(input);
