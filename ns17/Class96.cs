namespace ns17
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.Linq;

    internal class Class96 : Interface10
    {
        private readonly XObject xobject_0;

        public Class96(XObject xmlObject)
        {
            this.xobject_0 = xmlObject;
        }

        public virtual Interface10 imethod_0(Interface10 interface10_0)
        {
            throw new InvalidOperationException();
        }

        public virtual Interface10 Interface10_0
        {
            get
            {
                return null;
            }
        }

        public object Object_0
        {
            get
            {
                return this.xobject_0;
            }
        }

        public virtual IList<Interface10> Prop_0
        {
            get
            {
                return new List<Interface10>();
            }
        }

        public virtual IList<Interface10> Prop_1
        {
            get
            {
                return null;
            }
        }

        public virtual string String_0
        {
            get
            {
                return null;
            }
        }

        public virtual string String_1
        {
            get
            {
                return null;
            }
            set
            {
                throw new InvalidOperationException();
            }
        }

        public virtual string String_2
        {
            get
            {
                return null;
            }
        }

        public virtual XmlNodeType XmlNodeType_0
        {
            get
            {
                return this.xobject_0.NodeType;
            }
        }
    }
}

