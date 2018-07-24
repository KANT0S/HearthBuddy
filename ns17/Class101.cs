namespace ns17
{
    using System;
    using System.Xml.Linq;

    internal class Class101 : Class96
    {
        public Class101(XText text) : base(text)
        {
        }

        public override Interface10 Interface10_0
        {
            get
            {
                if (this.XText_0.Parent == null)
                {
                    return null;
                }
                return Class98.smethod_0(this.XText_0.Parent);
            }
        }

        public override string String_1
        {
            get
            {
                return this.XText_0.Value;
            }
            set
            {
                this.XText_0.Value = value;
            }
        }

        private XText XText_0
        {
            get
            {
                return (XText) base.Object_0;
            }
        }
    }
}

