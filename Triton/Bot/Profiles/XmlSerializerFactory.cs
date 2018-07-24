namespace Triton.Bot.Profiles
{
    using ns22;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Xml.Serialization;
    using Triton.Common;

    public class XmlSerializerFactory
    {
        public static XmlSerializer GetSerializerForCurrentDomain<T, TProfileTagType>()
        {
            XmlAttributeOverrides overrides = new XmlAttributeOverrides();
            smethod_0<TProfileTagType>(overrides);
            return new XmlSerializer(typeof(T), overrides, null, new XmlRootAttribute("Profile"), "");
        }

        private static void smethod_0<T>(XmlAttributeOverrides xmlAttributeOverrides_0)
        {
            Dictionary<Type, TypeFinder> dictionary = new Dictionary<Type, TypeFinder>();
            foreach (Tuple<MemberInfo, List<Attribute37>> tuple in new AttributeFinder<Attribute37>(true, false).AttributedMembers)
            {
                foreach (Attribute37 attribute in tuple.Item2)
                {
                    TypeFinder finder;
                    if (!dictionary.TryGetValue(attribute.Type_0, out finder))
                    {
                        finder = new TypeFinder(attribute.Type_0, false, true);
                    }
                    smethod_1(xmlAttributeOverrides_0, tuple.Item1.DeclaringType, tuple.Item1.Name, finder.InstanceTypes);
                }
            }
        }

        private static void smethod_1(XmlAttributeOverrides xmlAttributeOverrides_0, Type type_0, string string_0, IEnumerable<Type> ienumerable_0)
        {
            XmlAttributes attributes = new XmlAttributes();
            foreach (MemberInfo info in type_0.GetMembers())
            {
                if (info.Name == string_0)
                {
                    foreach (XmlElementAttribute attribute in info.GetCustomAttributes(typeof(XmlElementAttribute), false))
                    {
                        attributes.XmlElements.Add(attribute);
                    }
                }
            }
            foreach (Type type in ienumerable_0)
            {
                attributes.XmlElements.Add(new XmlElementAttribute(type.Name, type));
            }
            xmlAttributeOverrides_0.Add(type_0, string_0, attributes);
        }
    }
}

