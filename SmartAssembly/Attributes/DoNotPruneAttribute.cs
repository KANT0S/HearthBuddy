namespace SmartAssembly.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Parameter | AttributeTargets.Interface | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Module | AttributeTargets.Assembly)]
    public sealed class DoNotPruneAttribute : Attribute
    {
    }
}

