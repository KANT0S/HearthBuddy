namespace Triton.Bot.Profiles
{
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Xml.Serialization;
    using Triton.Bot;

    [Serializable, XmlRoot("Profile")]
    public class Profile : IAuthored
    {
        private readonly ILog _log = Logger.GetLoggerInstanceForType();
        private Dictionary<string, ProfileElement> _refList;

        public Profile()
        {
            this.Elements = new List<ProfileElement>();
        }

        public void BuildReferences()
        {
            this._refList = new Dictionary<string, ProfileElement>();
            foreach (ProfileElement element in this.Elements)
            {
                this.method_3(element);
            }
            foreach (ProfileElement element2 in this.Elements)
            {
                this.method_2(element2);
            }
        }

        public ProfileElement FindReferenceElement(ProfileElement element)
        {
            if (element == null)
            {
                return null;
            }
            if (string.IsNullOrEmpty(element.ReferenceTag))
            {
                return element;
            }
            ProfileElement element2 = this.method_0(element.ReferenceTag);
            if (element2 != null)
            {
                this._log.Debug(element + " references " + element2.ReferenceTag);
            }
            if (element2 != null)
            {
                element.ReferenceElement = element2;
            }
            return (element2 ?? element);
        }

        private ProfileElement method_0(string string_0)
        {
            ProfileElement element;
            if (this._refList == null)
            {
                this.BuildReferences();
            }
            if (this._refList.TryGetValue(string_0, out element))
            {
                return element;
            }
            return null;
        }

        private void method_1(ProfileElement profileElement_0, ProfileElement profileElement_1)
        {
            foreach (PropertyInfo info in profileElement_0.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).Where<PropertyInfo>(Class214.<>9__26_0 ?? (Class214.<>9__26_0 = new Func<PropertyInfo, bool>(Class214.<>9.method_0))))
            {
                object defaultValue = info.PropertyType.GetDefaultValue();
                DefaultValueAttribute customAttribute = info.GetCustomAttribute<DefaultValueAttribute>();
                if (customAttribute != null)
                {
                    defaultValue = customAttribute.Value;
                }
                object obj3 = info.GetValue(profileElement_0);
                object obj4 = info.GetValue(profileElement_1);
                if (((obj4 == null) || obj4.Equals(defaultValue)) && (((obj3 != null) && !obj3.Equals(defaultValue)) && ((obj4 == null) || !obj3.Equals(obj4))))
                {
                    info.SetValue(profileElement_1, obj3);
                }
            }
        }

        private void method_2(ProfileElement profileElement_0)
        {
            if (!string.IsNullOrEmpty(profileElement_0.ReferenceTag))
            {
                ProfileElement element = this.method_0(profileElement_0.ReferenceTag);
                if (element != null)
                {
                    profileElement_0.ReferenceElement = element;
                    this.method_1(element, profileElement_0);
                }
            }
            if (profileElement_0 is ProfileGroupElement)
            {
                foreach (ProfileElement element2 in (profileElement_0 as ProfileGroupElement).Children)
                {
                    this.method_2(element2);
                }
            }
        }

        private void method_3(ProfileElement profileElement_0)
        {
            if (!string.IsNullOrEmpty(profileElement_0.ReferenceName))
            {
                if (this._refList.ContainsKey(profileElement_0.ReferenceName))
                {
                    throw new Exception("Profile already contains a reference element with name " + profileElement_0.ReferenceName + ". Cannot correctly load reference!");
                }
                this._refList.Add(profileElement_0.ReferenceName, profileElement_0);
            }
            if (profileElement_0 is ProfileGroupElement)
            {
                foreach (ProfileElement element in (profileElement_0 as ProfileGroupElement).Children)
                {
                    this.method_3(element);
                }
            }
        }

        [XmlAttribute]
        public string Author { get; set; }

        [XmlAttribute]
        public string Description { get; set; }

        public List<ProfileElement> Elements { get; internal set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        [Serializable, CompilerGenerated]
        private sealed class Class214
        {
            public static readonly Profile.Class214 <>9 = new Profile.Class214();
            public static Func<PropertyInfo, bool> <>9__26_0;

            internal bool method_0(PropertyInfo propertyInfo_0)
            {
                XmlAttributeAttribute customAttribute = propertyInfo_0.GetCustomAttribute<XmlAttributeAttribute>();
                if (customAttribute == null)
                {
                    return propertyInfo_0.GetCustomAttributes<XmlElementAttribute>().Any<XmlElementAttribute>();
                }
                return (!(customAttribute.AttributeName == "RefTag") && !(customAttribute.AttributeName == "RefName"));
            }
        }
    }
}

