using HelloLib;

namespace GenTest;

[Component]
public partial class MyComp
{
    public int ID
    {
        get => GetID();
        set => SetID(value);
    }
    public float Value
    {
        get => GetValue();
        set => SetValue(value);
    }
}