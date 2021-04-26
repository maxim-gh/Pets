using System;

public class Calculator
{
    public int PriceCalculator(PetType petType, int diffcultyFactor)
    {
        if (petType == PetType.Dog)
        {
            return 150 + 70 * diffcultyFactor;
        } 
        return 100 + 50 * diffcultyFactor;
    }
}
