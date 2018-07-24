namespace JetBrains.Annotations
{
    using System;

    [AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    public sealed class CanBeNullAttribute : Attribute
    {
    }
}

