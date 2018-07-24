namespace SmartAssembly.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Class)]
    public sealed class DoNotPruneTypeAttribute : Attribute
    {
    }
}

