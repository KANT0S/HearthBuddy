namespace ns17
{
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;

    internal class Class99 : Class98, Interface10, Interface11
    {
        public Class99(XDocument document) : base(document)
        {
        }

        public override Interface10 imethod_0(Interface10 interface10_0)
        {
            Class97 class2 = interface10_0 as Class97;
            if (class2 != null)
            {
                this.XDocument_0.Declaration = class2.XDeclaration_0;
                return class2;
            }
            return base.imethod_0(interface10_0);
        }

        public Interface10 imethod_1(string string_0)
        {
            return new Class96(new XComment(string_0));
        }

        public Interface10 imethod_10(string string_0, string string_1)
        {
            return new Class104(new XAttribute(string_0, string_1));
        }

        public Interface10 imethod_11(string string_0, string string_1, string string_2)
        {
            return new Class104(new XAttribute(XName.Get(Class193.smethod_5(string_0), string_1), string_2));
        }

        public Interface10 imethod_2(string string_0)
        {
            return new Class96(new XText(string_0));
        }

        public Interface10 imethod_3(string string_0)
        {
            return new Class96(new XCData(string_0));
        }

        public Interface10 imethod_4(string string_0)
        {
            return new Class96(new XText(string_0));
        }

        public Interface10 imethod_5(string string_0)
        {
            return new Class96(new XText(string_0));
        }

        public Interface10 imethod_6(string string_0, string string_1, string string_2)
        {
            return new Class97(new XDeclaration(string_0, string_1, string_2));
        }

        public Interface10 imethod_7(string string_0, string string_1)
        {
            return new Class103(new XProcessingInstruction(string_0, string_1));
        }

        public Interface12 imethod_8(string string_0)
        {
            return new Class100(new XElement(string_0));
        }

        public Interface12 imethod_9(string string_0, string string_1)
        {
            return new Class100(new XElement(XName.Get(Class193.smethod_5(string_0), string_1)));
        }

        public Interface12 Interface12_0
        {
            get
            {
                if (this.XDocument_0.Root == null)
                {
                    return null;
                }
                return new Class100(this.XDocument_0.Root);
            }
        }

        public override IList<Interface10> Prop_0
        {
            get
            {
                IList<Interface10> list = base.Prop_0;
                if (this.XDocument_0.Declaration != null)
                {
                    list.Insert(0, new Class97(this.XDocument_0.Declaration));
                }
                return list;
            }
        }

        private XDocument XDocument_0
        {
            get
            {
                return (XDocument) base.Object_0;
            }
        }
    }
}

