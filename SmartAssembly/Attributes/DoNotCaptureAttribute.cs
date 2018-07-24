namespace SmartAssembly.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Struct | AttributeTargets.Class, Inherited=true)]
    public sealed class DoNotCaptureAttribute : Attribute
    {
    }
}

