namespace SmartAssembly.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Class)]
    public sealed class ObfuscateToAttribute : Attribute
    {
        public ObfuscateToAttribute(string newName)
        {
        }
    }
}

