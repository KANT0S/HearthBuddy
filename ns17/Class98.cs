namespace ns17
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Xml.Linq;

    internal class Class98 : Class96
    {
        [CompilerGenerated]
        private static Func<XNode, Interface10> func_0;

        public Class98(XContainer container) : base(container)
        {
        }

        public override Interface10 imethod_0(Interface10 interface10_0)
        {
            this.XContainer_0.Add(interface10_0.Object_0);
            return interface10_0;
        }

        internal static Interface10 smethod_0(XObject xobject_1)
        {
            if (xobject_1 is XDocument)
            {
                return new Class99((XDocument) xobject_1);
            }
            if (xobject_1 is XElement)
            {
                return new Class100((XElement) xobject_1);
            }
            if (xobject_1 is XContainer)
            {
                return new Class98((XContainer) xobject_1);
            }
            if (xobject_1 is XProcessingInstruction)
            {
                return new Class103((XProcessingInstruction) xobject_1);
            }
            if (xobject_1 is XText)
            {
                return new Class101((XText) xobject_1);
            }
            if (xobject_1 is XComment)
            {
                return new Class102((XComment) xobject_1);
            }
            if (xobject_1 is XAttribute)
            {
                return new Class104((XAttribute) xobject_1);
            }
            return new Class96(xobject_1);
        }

        [CompilerGenerated]
        private static Interface10 smethod_1(XNode xnode_0)
        {
            return smethod_0(xnode_0);
        }

        public override Interface10 Interface10_0
        {
            get
            {
                if (this.XContainer_0.Parent == null)
                {
                    return null;
                }
                return smethod_0(this.XContainer_0.Parent);
            }
        }

        public override IList<Interface10> Prop_0
        {
            get
            {
                if (func_0 == null)
                {
                    func_0 = new Func<XNode, Interface10>(Class98.smethod_1);
                }
                return this.XContainer_0.Nodes().Select<XNode, Interface10>(func_0).ToList<Interface10>();
            }
        }

        private XContainer XContainer_0
        {
            get
            {
                return (XContainer) base.Object_0;
            }
        }
    }
}

