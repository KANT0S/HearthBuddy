namespace JetBrains.Annotations
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Parameter)]
    public class PathReferenceAttribute : Attribute
    {
        [CompilerGenerated]
        private string string_0;

        public PathReferenceAttribute()
        {
        }

        [UsedImplicitly]
        public PathReferenceAttribute([PathReference] string basePath)
        {
            this.BasePath = basePath;
        }

        [UsedImplicitly]
        public string BasePath
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

