namespace JetBrains.Annotations
{
    using System;

    [MeansImplicitUse]
    public sealed class PublicAPIAttribute : Attribute
    {
        public PublicAPIAttribute()
        {
        }

        public PublicAPIAttribute(string comment)
        {
        }
    }
}

