using System;
public abstract class Dog : Pet
{

}
public class GermanShepherd : Dog
{
    private int _factor = 4;
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
    public GermanShepherd(string nickName)
    {
        NickName = nickName;
    }
}
public class Вachshund : Dog
{
    private int _factor = 1;
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
    public Вachshund(string nickName)
    {
        NickName = nickName;
    }
}
