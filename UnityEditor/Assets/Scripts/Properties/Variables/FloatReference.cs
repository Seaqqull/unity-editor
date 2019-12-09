using UnityEngine;
using System;

[Serializable]
public class FloatReference
{
    [SerializeField] private bool UseConstant = true;
    [SerializeField] private float ConstantValue;
#pragma warning disable 0649
    [SerializeField] private FloatVariable Variable;
#pragma warning restore 0649

    public float Value
    {
        get { return UseConstant ? ConstantValue : Variable.Value; }
    }


    public FloatReference() { }

    public FloatReference(float value)
    {
        UseConstant = true;
        ConstantValue = value;
    }
    

    public static implicit operator float(FloatReference reference)
    {
        return reference.Value;
    }
}
