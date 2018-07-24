namespace Triton.Bot.Profiles
{
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Serialization;
    using Triton.Common;

    public class ProfileLoader
    {
        private static readonly Dictionary<string, Type> dictionary_0 = new Dictionary<string, Type>();
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private static readonly TypeFinder<ProfileElement> typeFinder_0 = new TypeFinder<ProfileElement>(false, false);

        static ProfileLoader()
        {
            typeFinder_0.CollectionChanged += new NotifyCollectionChangedEventHandler(Class219.<>9.method_0);
            smethod_0();
        }

        public static ProfileElement LoadElement(List<ProfileElement> currentList, XElement element)
        {
            try
            {
                Type type;
                string localName = element.Name.LocalName;
                if (dictionary_0.TryGetValue(localName, out type))
                {
                    using (XmlReader reader = element.CreateReader())
                    {
                        ProfileElement element1 = new XmlSerializer(type).Deserialize(reader) as ProfileElement;
                        element1.LoadElement(currentList, element);
                        return element1;
                    }
                }
            }
            catch (InvalidOperationException exception)
            {
                ilog_0.Error("An error occured while loading the profile. Are you sure the profile contains no XML errors?");
                ilog_0.ErrorFormat("XML Error: {0}", (exception.InnerException != null) ? exception.InnerException.ToString() : "None");
            }
            return null;
        }

        public static Profile LoadProfile(string path)
        {
            XElement element = XElement.Load(File.OpenRead(path));
            Profile profile = Triton.Bot.Profiles.XmlSerializerFactory.GetSerializerForCurrentDomain<Profile, ProfileElement>().Deserialize(File.OpenRead(path)) as Profile;
            if ((element == null) || (profile == null))
            {
                throw new Exception("Error while loading profile! Loaded Element was null.");
            }
            foreach (XElement element2 in element.Elements())
            {
                ProfileElement item = LoadElement(profile.Elements, element2);
                if (item != null)
                {
                    profile.Elements.Add(item);
                }
                else
                {
                    ilog_0.Error(string.Concat(new object[] { "Unknown profile element: ", element2, " at line ", element2.LineNumber }));
                }
            }
            return profile;
        }

        private static void smethod_0()
        {
            dictionary_0.Clear();
            foreach (Type type in typeFinder_0.InstanceTypes)
            {
                ProfileElementNameAttribute customAttribute = type.GetCustomAttribute<ProfileElementNameAttribute>();
                if (customAttribute != null)
                {
                    dictionary_0.Add(customAttribute.ElementName, type);
                }
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class219
        {
            public static readonly ProfileLoader.Class219 <>9 = new ProfileLoader.Class219();

            internal void method_0(object sender, NotifyCollectionChangedEventArgs e)
            {
                ProfileLoader.smethod_0();
            }
        }
    }
}

