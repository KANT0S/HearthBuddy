namespace JetBrains.Annotations
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
    public sealed class AspMvcActionAttribute : Attribute
    {
        [CompilerGenerated]
        private string string_0;

        public AspMvcActionAttribute()
        {
        }

        public AspMvcActionAttribute(string anonymousProperty)
        {
            this.AnonymousProperty = anonymousProperty;
        }

        [UsedImplicitly]
        public string AnonymousProperty
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            private set
            {
                this.string_0 = value;
            }
        }
    }
}

