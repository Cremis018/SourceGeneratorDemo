using Godot;
using System;
using HelloLib;

[Component]
public partial class MyClass2 : Node
{
    [Export] public float Speed { get => GetSpeed(); set => SetSpeed(value); }
}
