using System;

public sealed class Const<T> 
{
    public bool isConst = false;
    private T value;


    public Const( T value ,bool isConst = false)
    {

        this.value = value;
        this.isConst = isConst;
    }

    public static explicit operator T(Const<T> c) => c.value;
    public T GetValue()
    {
        return this.value;
    }
    public T SetValue(T value)
    {

        this.value = isConst ? this.value : value;
        return this.value;
    }
}