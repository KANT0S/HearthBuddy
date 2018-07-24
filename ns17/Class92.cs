namespace ns17
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Xml;

    internal class Class92 : Interface10
    {
        private readonly System.Xml.XmlNode xmlNode_0;

        public Class92(System.Xml.XmlNode node)
        {
            this.xmlNode_0 = node;
        }

        public Interface10 imethod_0(Interface10 interface10_0)
        {
            Class92 class2 = (Class92) interface10_0;
            this.xmlNode_0.AppendChild(class2.xmlNode_0);
            return interface10_0;
        }

        private Interface10 method_0(System.Xml.XmlNode xmlNode_1)
        {
            XmlNodeType nodeType = xmlNode_1.NodeType;
            if (nodeType == XmlNodeType.Element)
            {
                return new Class94((XmlElement) xmlNode_1);
            }
            if (nodeType != XmlNodeType.XmlDeclaration)
            {
                return new Class92(xmlNode_1);
            }
            return new Class95((XmlDeclaration) xmlNode_1);
        }

        [CompilerGenerated]
        private Interface10 method_1(System.Xml.XmlNode xmlNode_1)
        {
            return this.method_0(xmlNode_1);
        }

        [CompilerGenerated]
        private Interface10 method_2(System.Xml.XmlAttribute xmlAttribute_0)
        {
            return this.method_0(xmlAttribute_0);
        }

        public Interface10 Interface10_0
        {
            get
            {
                System.Xml.XmlNode node = (this.xmlNode_0 is System.Xml.XmlAttribute) ? ((System.Xml.XmlAttribute) this.xmlNode_0).OwnerElement : this.xmlNode_0.ParentNode;
                if (node == null)
                {
                    return null;
                }
                return this.method_0(node);
            }
        }

        public object Object_0
        {
            get
            {
                return this.xmlNode_0;
            }
        }

        public IList<Interface10> Prop_0
        {
            get
            {
                return this.xmlNode_0.ChildNodes.Cast<System.Xml.XmlNode>().Select<System.Xml.XmlNode, Interface10>(new Func<System.Xml.XmlNode, Interface10>(this.method_1)).ToList<Interface10>();
            }
        }

        public IList<Interface10> Prop_1
        {
            get
            {
                if (this.xmlNode_0.Attributes == null)
                {
                    return null;
                }
                return this.xmlNode_0.Attributes.Cast<System.Xml.XmlAttribute>().Select<System.Xml.XmlAttribute, Interface10>(new Func<System.Xml.XmlAttribute, Interface10>(this.method_2)).ToList<Interface10>();
            }
        }

        public string String_0
        {
            get
            {
                return this.xmlNode_0.LocalName;
            }
        }

        public string String_1
        {
            get
            {
                return this.xmlNode_0.Value;
            }
            set
            {
                this.xmlNode_0.Value = value;
            }
        }

        public string String_2
        {
            get
            {
                return this.xmlNode_0.NamespaceURI;
            }
        }

        public XmlNodeType XmlNodeType_0
        {
            get
            {
                return this.xmlNode_0.NodeType;
            }
        }
    }
}

