namespace ns17
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Xml;
    using System.Xml.Linq;

    internal class Class97 : Class96, Interface10, Interface13
    {
        [CompilerGenerated]
        private XDeclaration xdeclaration_0;

        public Class97(XDeclaration declaration) : base(null)
        {
            this.XDeclaration_0 = declaration;
        }

        public string String_3
        {
            get
            {
                return this.XDeclaration_0.Version;
            }
        }

        public string String_4
        {
            get
            {
                return this.XDeclaration_0.Encoding;
            }
            set
            {
                this.XDeclaration_0.Encoding = value;
            }
        }

        public string String_5
        {
            get
            {
                return this.XDeclaration_0.Standalone;
            }
            set
            {
                this.XDeclaration_0.Standalone = value;
            }
        }

        internal XDeclaration XDeclaration_0
        {
            [CompilerGenerated]
            get
            {
                return this.xdeclaration_0;
            }
            [CompilerGenerated]
            private set
            {
                this.xdeclaration_0 = value;
            }
        }

        public override XmlNodeType XmlNodeType_0
        {
            get
            {
                return XmlNodeType.XmlDeclaration;
            }
        }
    }
}

