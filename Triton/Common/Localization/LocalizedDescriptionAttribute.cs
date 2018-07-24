namespace Triton.Common.Localization
{
    using System;
    using System.ComponentModel;
    using System.Resources;

    public class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        private readonly ResourceManager resourceManager_0;
        private readonly string string_0;

        public LocalizedDescriptionAttribute(string resourceName)
        {
            this.string_0 = resourceName;
            this.resourceManager_0 = Globalization.ResourceManager;
        }

        public override string Description
        {
            get
            {
                return this.resourceManager_0.GetString(this.string_0);
            }
        }
    }
}

