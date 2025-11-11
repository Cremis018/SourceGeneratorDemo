using System;

namespace EcsDemo;

[AttributeUsage(AttributeTargets.Property)]
public sealed class DefaultAttribute : Attribute
{
    public object? Value { get; set; }
}