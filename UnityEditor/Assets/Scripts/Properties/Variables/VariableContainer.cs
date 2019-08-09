using UnityEngine;

public class VariableContainer : MonoBehaviour
{
    public FloatReference Float;
    public IntegerReference Int;
    [TagSelector] public string[] Tags;
}
