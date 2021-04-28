using System;

public class Calculator
{
    public int PriceCalculator(Pet pet)
    {
        if (pet is Dog)
        {
            return 150 + 70 * pet.DiffcultyFactor;
        }
        return 100 + 50 * pet.DiffcultyFactor;
    }
}
