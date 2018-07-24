namespace JetBrains.Annotations
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class AspMvcAreaAttribute : PathReferenceAttribute
    {
        [CompilerGenerated]
        private string string_1;

        [UsedImplicitly]
        public AspMvcAreaAttribute()
        {
        }

        public AspMvcAreaAttribute(string anonymousProperty)
        {
            this.AnonymousProperty = anonymousProperty;
        }

        [UsedImplicitly]
        public string AnonymousProperty
        {
            [CompilerGenerated]
            get
            {
                return this.string_1;
            }
            [CompilerGenerated]
            private set
            {
                this.string_1 = value;
            }
        }
    }
}

