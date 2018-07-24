namespace Newtonsoft.Json
{
    using System;

    [Flags]
    public enum DefaultValueHandling
    {
        Include,
        Ignore,
        Populate,
        IgnoreAndPopulate
    }
}

