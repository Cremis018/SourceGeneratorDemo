using Godot;
using System;
using SourceGeneratorDemo.Generator;

public partial class GeneratorTest : Node
{
    public override void _Ready()
    {
        HelloWorld.SayHello();
    }
}
