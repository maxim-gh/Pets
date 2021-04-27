using System;

public class Visitor
{
	public string FirstName { get; }
	public string Surname { get; }
	public string PhoneNumber { get; }
    public DateTime DateTime { get; }
    public Pet Pet { get; }

    public Visitor(string firstName, string surname, string phoneNumber, DateTime dateTime, Pet pet)
    {
        FirstName = firstName;
        Surname = surname;
        PhoneNumber = phoneNumber;
        DateTime = dateTime;
        Pet = pet;
    }
}
