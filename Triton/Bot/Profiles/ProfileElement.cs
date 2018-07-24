namespace Triton.Bot.Profiles
{
    using Buddy.Coroutines;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using System.Xml.Serialization;
    using Triton.Bot;

    [Serializable]
    public abstract class ProfileElement : IAuthored
    {
        protected ProfileElement()
        {
        }

        public virtual void LoadElement(List<ProfileElement> currentList, XElement element)
        {
        }

        public virtual void OnRegistered()
        {
        }

        public virtual void OnUnregistered()
        {
        }

        public virtual Task ProfileTagLogic()
        {
            return Coroutine.Yield();
        }

        public virtual void Pulse()
        {
        }

        public virtual void Reset()
        {
        }

        [XmlIgnore]
        public abstract string Author { get; }

        [XmlAttribute]
        public abstract string Description { get; }

        [XmlIgnore]
        public string ElementName
        {
            get
            {
                return base.GetType().GetCustomAttribute<ProfileElementNameAttribute>().ElementName;
            }
        }

        [XmlIgnore]
        public virtual bool IsFinished
        {
            get
            {
                return false;
            }
        }

        [XmlIgnore]
        public abstract string Name { get; }

        [XmlIgnore]
        public ProfileElement ReferenceElement { get; set; }

        [XmlAttribute("RefName")]
        public string ReferenceName { get; set; }

        [XmlAttribute("RefTag")]
        public string ReferenceTag { get; set; }

        [XmlIgnore]
        public abstract string Version { get; }
    }
}

