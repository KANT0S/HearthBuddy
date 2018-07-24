namespace JetBrains.Annotations
{
    using System;

    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public sealed class CannotApplyEqualityOperatorAttribute : Attribute
    {
    }
}

