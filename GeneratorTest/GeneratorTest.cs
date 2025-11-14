using Godot;
using System;
using HelloLib;
using My;

public partial class GeneratorTest : Node
{
    [Export] private MyClass MyClass { get; set; }
    
    public override void _Ready()
    {
        GD.Print(MyClass.PropertyOne);
        GD.Print(MyClass.PropertyTwo);
        GD.Print(MyClass.PropertyThree.Name);
    }
}

//生成出来的，MyClass.g.cs
//原来的namespace是啥，它的namespace就是啥
//原来的using有哪些，它的using就有哪些
// public partial class MyClass
// {
//     private int _propertyOne = 1;
//     public int GetPropertyOne() => _propertyOne;
//     public void SetPropertyOne(int value)
//     {
//         PropertyOneChanging?.Invoke(value);
//         if (Equals(value,_propertyOne)) return;
//         _propertyOne = value;
//         PropertyOneChanged?.Invoke(value);
//     }
//     public event Action<int> PropertyOneChanging;
//     public event Action<int> PropertyOneChanged;
//     
//     private string _propertyTwo = "Hi";
//     public string GetPropertyTwo() => _propertyTwo;
//     public void SetPropertyTwo(string value)
//     {
//         PropertyTwoChanging?.Invoke(value);
//         if (Equals(value,_propertyTwo)) return;
//         _propertyTwo = value;
//         PropertyTwoChanged?.Invoke(value);
//     }
//     public event Action<string> PropertyTwoChanging;
//     public event Action<string> PropertyTwoChanged;
//
//     private Node _propertyThree;
//     public Node GetPropertyThree() => _propertyThree;
//     public void SetPropertyThree(Node value)
//     {
//         PropertyThreeChanging?.Invoke(value);
//         if (Equals(value,_propertyThree)) return;
//         _propertyThree = value;
//         PropertyThreeChanged?.Invoke(value);
//     }
//     public event Action<Node> PropertyThreeChanging;
//     public event Action<Node> PropertyThreeChanged;
// }
