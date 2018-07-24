namespace JetBrains.Annotations
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor, AllowMultiple=false, Inherited=true)]
    public sealed class StringFormatMethodAttribute : Attribute
    {
        [CompilerGenerated]
        private string string_0;

        public StringFormatMethodAttribute(string formatParameterName)
        {
            this.FormatParameterName = formatParameterName;
        }

        [UsedImplicitly]
        public string FormatParameterName
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

