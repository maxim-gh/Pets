using System;

public class Cat : Pet
{

}
public class Persian : Cat
{
    private int _factor = 3;
    public override int DiffcultyFactor
    {
        get
        {
            return _factor;
        }
        set
        {
            DiffcultyFactor = _factor;
        }
    }
}
public class AmericanShorthair : Cat
{
    private int _factor = 2;
    public override int DiffcultyFactor
    {
        get
        {
            return _factor;
        }
        set
        {
            DiffcultyFactor = _factor;
        }
    }
}
