public record Student(string fullName, string speciality, int year)
{
    public string FullName { get; set; } = fullName;
    public string Speciality { get; set; } = speciality;
    public int Year { get; set; } = year;
}
