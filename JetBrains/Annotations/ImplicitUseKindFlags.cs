namespace JetBrains.Annotations
{
    using System;

    [Flags]
    public enum ImplicitUseKindFlags
    {
        Access = 1,
        Assign = 2,
        Default = 7,
        InstantiatedNoFixedConstructorSignature = 8,
        InstantiatedWithFixedConstructorSignature = 4
    }
}

