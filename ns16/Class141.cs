namespace ns16
{
    using ns20;
    using System;
    using System.Reflection;

    internal class Class141 : Interface14
    {
        private readonly object object_0;
        private static PropertyInfo propertyInfo_0;

        public Class141(object attribute)
        {
            this.object_0 = attribute;
        }

        public Type Type_0
        {
            get
            {
                if (propertyInfo_0 == null)
                {
                    propertyInfo_0 = this.object_0.GetType().GetProperty("MetadataClassType");
                }
                return (Type) Class194.smethod_23(propertyInfo_0, this.object_0);
            }
        }
    }
}

