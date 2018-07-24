namespace Triton.Game.Mapping
{
    using System;

    [Flags]
    public enum HideFlags
    {
        DontSave = 4,
        HideAndDontSave = 13,
        HideInHierarchy = 1,
        HideInInspector = 2,
        None = 0,
        NotEditable = 8
    }
}

