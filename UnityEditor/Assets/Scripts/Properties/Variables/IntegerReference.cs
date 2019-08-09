using UnityEngine;
using System;

[Serializable]
public class IntegerReference
{
    [SerializeField] private bool UseConstant = true;
    [SerializeField] private int ConstantValue;
    [SerializeField] private IntegerVariable Variable;

    public int Value
    {
        get { return UseConstant ? ConstantValue : Variable.Value; }
    }


    public IntegerReference() { }

    public IntegerReference(int value)
    {
        UseConstant = true;
        ConstantValue = value;
    }


    public static implicit operator int(IntegerReference reference)
    {
        return reference.Value;
    }
}
