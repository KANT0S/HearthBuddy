namespace SmartAssembly.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Struct | AttributeTargets.Class)]
    public sealed class ObfuscateControlFlowAttribute : Attribute
    {
    }
}

