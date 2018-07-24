namespace SmartAssembly.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Class)]
    public sealed class StayPublicAttribute : Attribute
    {
    }
}

