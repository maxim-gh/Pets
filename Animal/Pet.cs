using System;

public class Pet
{
	public string NickName { get; }
	public string Breed { get; }
    public int DiffcultyFactor { get; }
	public PetType PetType { get; }

    public Pet(string nickName, string breed, PetType petType, int diffcultyFactor)
    {
        NickName = nickName;
        Breed = breed;
        PetType = petType;
        DiffcultyFactor = diffcultyFactor;
    }
}
