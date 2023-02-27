namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel();
            Console.ReadLine();
        }
    }
}

public class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public PersonModel()
    {

    }
    public PersonModel(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public PersonModel(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}