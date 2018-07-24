namespace SmartAssembly.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Interface | AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Module | AttributeTargets.Assembly)]
    public sealed class DoNotObfuscateAttribute : Attribute
    {
    }
}

