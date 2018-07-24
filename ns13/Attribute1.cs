namespace ns13
{
    using System;

    [AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    internal sealed class Attribute1 : Attribute
    {
    }
}

