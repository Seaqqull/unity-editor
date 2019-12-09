using UnityEngine;

public class VariableContainer : MonoBehaviour
{
    [BeginReadOnlyGroup]
    public string entityName = "Some entity name";
    [ReadOnly] public int val = 7;
    [EndReadOnlyGroup]


    public FloatReference Float;
    public IntegerReference Int;
    [TagSelector] public string[] Tags;
}
