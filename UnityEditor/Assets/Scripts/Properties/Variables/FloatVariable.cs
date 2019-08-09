using UnityEngine;

[CreateAssetMenu(menuName = "Variable/Float")]
public class FloatVariable : ScriptableObject
{
#if UNITY_EDITOR
    [Multiline]
    [SerializeField] private string _description = "";
#endif
    [SerializeField] private float _value;

    public float Value
    {
        get { return this._value; }
        private set { this._value = value; }
    }


    public void SetValue(float value)
    {
        Value = value;
    }

    public void SetValue(FloatVariable value)
    {
        Value = value.Value;
    }


    public void ApplyChange(float amount)
    {
        Value += amount;
    }
    
    public void ApplyChange(FloatVariable amount)
    {
        Value += amount.Value;
    }
}
