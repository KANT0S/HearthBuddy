namespace ns17
{
    using System;
    using System.Xml.Linq;

    internal class Class102 : Class96
    {
        public Class102(XComment text) : base(text)
        {
        }

        public override Interface10 Interface10_0
        {
            get
            {
                if (this.XComment_0.Parent == null)
                {
                    return null;
                }
                return Class98.smethod_0(this.XComment_0.Parent);
            }
        }

        public override string String_1
        {
            get
            {
                return this.XComment_0.Value;
            }
            set
            {
                this.XComment_0.Value = value;
            }
        }

        private XComment XComment_0
        {
            get
            {
                return (XComment) base.Object_0;
            }
        }
    }
}

