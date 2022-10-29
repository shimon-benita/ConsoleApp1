public class Person
{
    public string? firstName;
    public string? lastName;

    public void Introduce()
    {
        Console.WriteLine("Hello! my name is: " + firstName + " " + lastName);
    }
}