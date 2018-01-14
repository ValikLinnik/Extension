using System;

[Serializable]
public class OverrodeOperator
{
    public static implicit operator bool(OverrodeOperator obj)
    {
        return obj != null;
    }
}
