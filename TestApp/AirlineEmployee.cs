namespace TestApp;

public class AirlineEmployee
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    
    public AirlineEmployee(string name, DateTime birthDate)
    {
        Name = name;
        BirthDate = birthDate;
    }
}