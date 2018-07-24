namespace Newtonsoft.Json.Serialization
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.Runtime.InteropServices;

    public class JsonPropertyCollection : KeyedCollection<string, JsonProperty>
    {
        private readonly Type type_0;

        public JsonPropertyCollection(Type type) : base(StringComparer.Ordinal)
        {
            Class203.smethod_2(type, "type");
            this.type_0 = type;
        }

        public void AddProperty(JsonProperty property)
        {
            if (base.Contains(property.PropertyName))
            {
                if (property.Ignored)
                {
                    return;
                }
                JsonProperty item = base[property.PropertyName];
                bool flag = true;
                if (item.Ignored)
                {
                    base.Remove(item);
                    flag = false;
                }
                else if ((property.DeclaringType != null) && (item.DeclaringType != null))
                {
                    if (property.DeclaringType.IsSubclassOf(item.DeclaringType))
                    {
                        base.Remove(item);
                        flag = false;
                    }
                    if (item.DeclaringType.IsSubclassOf(property.DeclaringType))
                    {
                        return;
                    }
                }
                if (flag)
                {
                    throw new JsonSerializationException("A member with the name '{0}' already exists on '{1}'. Use the JsonPropertyAttribute to specify another name.".smethod_1(CultureInfo.InvariantCulture, property.PropertyName, this.type_0));
                }
            }
            base.Add(property);
        }

        public JsonProperty GetClosestMatchProperty(string propertyName)
        {
            JsonProperty property = this.GetProperty(propertyName, StringComparison.Ordinal);
            if (property == null)
            {
                property = this.GetProperty(propertyName, StringComparison.OrdinalIgnoreCase);
            }
            return property;
        }

        protected override string GetKeyForItem(JsonProperty item)
        {
            return item.PropertyName;
        }

        public JsonProperty GetProperty(string propertyName, StringComparison comparisonType)
        {
            if (comparisonType == StringComparison.Ordinal)
            {
                JsonProperty property;
                if (this.method_0(propertyName, out property))
                {
                    return property;
                }
                return null;
            }
            foreach (JsonProperty property2 in this)
            {
                if (string.Equals(propertyName, property2.PropertyName, comparisonType))
                {
                    return property2;
                }
            }
            return null;
        }

        private bool method_0(string string_0, out JsonProperty jsonProperty_0)
        {
            if (base.Dictionary == null)
            {
                jsonProperty_0 = null;
                return false;
            }
            return base.Dictionary.TryGetValue(string_0, out jsonProperty_0);
        }
    }
}

