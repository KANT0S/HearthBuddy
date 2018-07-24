namespace SmartAssembly.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Module | AttributeTargets.Assembly)]
    public sealed class DoNotEncodeStringsAttribute : Attribute
    {
    }
}

