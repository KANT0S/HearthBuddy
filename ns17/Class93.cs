namespace ns17
{
    using System;
    using System.Xml;

    internal class Class93 : Class92, Interface10, Interface11
    {
        private readonly XmlDocument xmlDocument_0;

        public Class93(XmlDocument document) : base(document)
        {
            this.xmlDocument_0 = document;
        }

        public Interface10 imethod_1(string string_0)
        {
            return new Class92(this.xmlDocument_0.CreateComment(string_0));
        }

        public Interface10 imethod_10(string string_0, string string_1)
        {
            return new Class92(this.xmlDocument_0.CreateAttribute(string_0)) { String_1 = string_1 };
        }

        public Interface10 imethod_11(string string_0, string string_1, string string_2)
        {
            return new Class92(this.xmlDocument_0.CreateAttribute(string_0, string_1)) { String_1 = string_2 };
        }

        public Interface10 imethod_2(string string_0)
        {
            return new Class92(this.xmlDocument_0.CreateTextNode(string_0));
        }

        public Interface10 imethod_3(string string_0)
        {
            return new Class92(this.xmlDocument_0.CreateCDataSection(string_0));
        }

        public Interface10 imethod_4(string string_0)
        {
            return new Class92(this.xmlDocument_0.CreateWhitespace(string_0));
        }

        public Interface10 imethod_5(string string_0)
        {
            return new Class92(this.xmlDocument_0.CreateSignificantWhitespace(string_0));
        }

        public Interface10 imethod_6(string string_0, string string_1, string string_2)
        {
            return new Class92(this.xmlDocument_0.CreateXmlDeclaration(string_0, string_1, string_2));
        }

        public Interface10 imethod_7(string string_0, string string_1)
        {
            return new Class92(this.xmlDocument_0.CreateProcessingInstruction(string_0, string_1));
        }

        public Interface12 imethod_8(string string_0)
        {
            return new Class94(this.xmlDocument_0.CreateElement(string_0));
        }

        public Interface12 imethod_9(string string_0, string string_1)
        {
            return new Class94(this.xmlDocument_0.CreateElement(string_0, string_1));
        }

        public Interface12 Interface12_0
        {
            get
            {
                if (this.xmlDocument_0.DocumentElement == null)
                {
                    return null;
                }
                return new Class94(this.xmlDocument_0.DocumentElement);
            }
        }
    }
}

