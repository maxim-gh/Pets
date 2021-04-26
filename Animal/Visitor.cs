using System;

public class Visitor
{
	public string FirstName { get; }
	public string Surname { get; }
	public string PhoneNumber { get; }

    public Visitor(string firstName, string surname, string phoneNumber)
    {
        FirstName = firstName;
        Surname = surname;
        PhoneNumber = phoneNumber;
    }
}
