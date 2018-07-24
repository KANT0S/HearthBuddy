namespace ns17
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Xml.Linq;

    internal class Class100 : Class98, Interface10, Interface12
    {
        [CompilerGenerated]
        private static Func<XAttribute, Class104> func_1;

        public Class100(XElement element) : base(element)
        {
        }

        public void imethod_1(Interface10 interface10_0)
        {
            Class96 class2 = (Class96) interface10_0;
            this.XElement_0.Add(class2.Object_0);
        }

        public string imethod_2(string string_0)
        {
            return this.XElement_0.GetPrefixOfNamespace(string_0);
        }

        [CompilerGenerated]
        private static Class104 smethod_2(XAttribute xattribute_0)
        {
            return new Class104(xattribute_0);
        }

        public override IList<Interface10> Prop_1
        {
            get
            {
                if (func_1 == null)
                {
                    func_1 = new Func<XAttribute, Class104>(Class100.smethod_2);
                }
                return this.XElement_0.Attributes().Select<XAttribute, Class104>(func_1).Cast<Interface10>().ToList<Interface10>();
            }
        }

        public override string String_0
        {
            get
            {
                return this.XElement_0.Name.LocalName;
            }
        }

        public override string String_1
        {
            get
            {
                return this.XElement_0.Value;
            }
            set
            {
                this.XElement_0.Value = value;
            }
        }

        public override string String_2
        {
            get
            {
                return this.XElement_0.Name.NamespaceName;
            }
        }

        private XElement XElement_0
        {
            get
            {
                return (XElement) base.Object_0;
            }
        }
    }
}

