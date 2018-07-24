namespace ns17
{
    using System;
    using System.Xml.Linq;

    internal class Class104 : Class96
    {
        public Class104(XAttribute attribute) : base(attribute)
        {
        }

        public override Interface10 Interface10_0
        {
            get
            {
                if (this.XAttribute_0.Parent == null)
                {
                    return null;
                }
                return Class98.smethod_0(this.XAttribute_0.Parent);
            }
        }

        public override string String_0
        {
            get
            {
                return this.XAttribute_0.Name.LocalName;
            }
        }

        public override string String_1
        {
            get
            {
                return this.XAttribute_0.Value;
            }
            set
            {
                this.XAttribute_0.Value = value;
            }
        }

        public override string String_2
        {
            get
            {
                return this.XAttribute_0.Name.NamespaceName;
            }
        }

        private XAttribute XAttribute_0
        {
            get
            {
                return (XAttribute) base.Object_0;
            }
        }
    }
}

