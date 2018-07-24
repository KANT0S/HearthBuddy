namespace ns17
{
    using System;
    using System.Xml;

    internal class Class95 : Class92, Interface10, Interface13
    {
        private readonly XmlDeclaration xmlDeclaration_0;

        public Class95(XmlDeclaration declaration) : base(declaration)
        {
            this.xmlDeclaration_0 = declaration;
        }

        public string String_3
        {
            get
            {
                return this.xmlDeclaration_0.Version;
            }
        }

        public string String_4
        {
            get
            {
                return this.xmlDeclaration_0.Encoding;
            }
            set
            {
                this.xmlDeclaration_0.Encoding = value;
            }
        }

        public string String_5
        {
            get
            {
                return this.xmlDeclaration_0.Standalone;
            }
            set
            {
                this.xmlDeclaration_0.Standalone = value;
            }
        }
    }
}

