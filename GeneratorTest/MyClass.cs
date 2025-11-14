using HelloLib;
using Godot;

namespace My;

[Component]
public partial class MyClass : Node
{
    [Default(Value = 1),Export] public int PropertyOne { get => GetPropertyOne(); set => SetPropertyOne(value); }
    [Default(Value = "Hi"),Export] public string PropertyTwo { get => GetPropertyTwo(); set => SetPropertyTwo(value); }
    [Export] public Node PropertyThree { get => GetPropertyThree(); set => SetPropertyThree(value); }
}