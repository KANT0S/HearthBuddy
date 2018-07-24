namespace Triton.Bot.Profiles
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Class, Inherited=false, AllowMultiple=false)]
    public sealed class ProfileElementNameAttribute : Attribute
    {
        [CompilerGenerated]
        private string string_0;

        public ProfileElementNameAttribute(string elementName)
        {
            this.ElementName = elementName;
        }

        public string ElementName
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

