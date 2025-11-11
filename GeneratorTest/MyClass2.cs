using Godot;
using System;
using EcsDemo;

[Component]
public partial class MyClass2 : Node
{
    [Export] public float Speed { get => GetSpeed(); set => SetSpeed(value); }
}
