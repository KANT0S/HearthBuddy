namespace Newtonsoft.Json.Linq
{
    using ns20;
    using System;
    using System.ComponentModel;

    public class JPropertyDescriptor : PropertyDescriptor
    {
        private readonly Type type_0;

        public JPropertyDescriptor(string name, Type propertyType) : base(name, null)
        {
            Class203.smethod_2(name, "name");
            Class203.smethod_2(propertyType, "propertyType");
            this.type_0 = propertyType;
        }

        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override object GetValue(object component)
        {
            return smethod_0(component)[this.Name];
        }

        public override void ResetValue(object component)
        {
        }

        public override void SetValue(object component, object value)
        {
            JToken token = (value is JToken) ? ((JToken) value) : new JValue(value);
            smethod_0(component)[this.Name] = token;
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }

        private static JObject smethod_0(object object_0)
        {
            return (JObject) object_0;
        }

        public override Type ComponentType
        {
            get
            {
                return typeof(JObject);
            }
        }

        public override bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        protected override int NameHashCode
        {
            get
            {
                return base.NameHashCode;
            }
        }

        public override Type PropertyType
        {
            get
            {
                return this.type_0;
            }
        }
    }
}

