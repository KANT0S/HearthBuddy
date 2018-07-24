namespace SmartAssembly.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Class)]
    public sealed class ObfuscateNamespaceToAttribute : Attribute
    {
        public ObfuscateNamespaceToAttribute(string newName)
        {
        }
    }
}

