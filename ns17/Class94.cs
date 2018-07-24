namespace ns17
{
    using System;
    using System.Xml;

    internal class Class94 : Class92, Interface10, Interface12
    {
        private readonly XmlElement xmlElement_0;

        public Class94(XmlElement element) : base(element)
        {
            this.xmlElement_0 = element;
        }

        public void imethod_1(Interface10 interface10_0)
        {
            Class92 class2 = (Class92) interface10_0;
            this.xmlElement_0.SetAttributeNode((System.Xml.XmlAttribute) class2.Object_0);
        }

        public string imethod_2(string string_0)
        {
            return this.xmlElement_0.GetPrefixOfNamespace(string_0);
        }
    }
}

