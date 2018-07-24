namespace JetBrains.Annotations
{
    using System;

    [AttributeUsage(AttributeTargets.Method, Inherited=true)]
    public sealed class PureAttribute : Attribute
    {
    }
}

