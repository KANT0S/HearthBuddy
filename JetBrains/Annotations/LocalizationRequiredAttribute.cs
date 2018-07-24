namespace JetBrains.Annotations
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class LocalizationRequiredAttribute : Attribute
    {
        [CompilerGenerated]
        private bool bool_0;

        public LocalizationRequiredAttribute() : this(true)
        {
        }

        public LocalizationRequiredAttribute(bool required)
        {
            this.Required = required;
        }

        public override bool Equals(object obj)
        {
            LocalizationRequiredAttribute attribute = obj as LocalizationRequiredAttribute;
            return ((attribute != null) && (attribute.Required == this.Required));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [UsedImplicitly]
        public bool Required
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_0 = value;
            }
        }
    }
}

