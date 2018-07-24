namespace JetBrains.Annotations
{
    using System;

    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple=false, Inherited=true)]
    public sealed class InvokerParameterNameAttribute : Attribute
    {
    }
}

