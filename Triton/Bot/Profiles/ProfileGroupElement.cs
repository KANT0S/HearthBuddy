namespace Triton.Bot.Profiles
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Xml.Linq;

    public abstract class ProfileGroupElement : ProfileElement
    {
        [CompilerGenerated]
        private List<ProfileElement> list_0;

        protected ProfileGroupElement()
        {
            this.Children = new List<ProfileElement>();
        }

        public override void LoadElement(List<ProfileElement> currentList, XElement element)
        {
            base.LoadElement(currentList, element);
            foreach (XElement element2 in element.Elements())
            {
                this.Children.Add(ProfileLoader.LoadElement(this.Children, element2));
            }
        }

        public override void Reset()
        {
            using (List<ProfileElement>.Enumerator enumerator = this.Children.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    enumerator.Current.Reset();
                }
            }
        }

        public List<ProfileElement> Children
        {
            [CompilerGenerated]
            get
            {
                return this.list_0;
            }
            [CompilerGenerated]
            private set
            {
                this.list_0 = value;
            }
        }
    }
}

