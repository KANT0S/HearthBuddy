namespace ns17
{
    using System;
    using System.Xml.Linq;

    internal class Class103 : Class96
    {
        public Class103(XProcessingInstruction processingInstruction) : base(processingInstruction)
        {
        }

        public override string String_0
        {
            get
            {
                return this.XProcessingInstruction_0.Target;
            }
        }

        public override string String_1
        {
            get
            {
                return this.XProcessingInstruction_0.Data;
            }
            set
            {
                this.XProcessingInstruction_0.Data = value;
            }
        }

        private XProcessingInstruction XProcessingInstruction_0
        {
            get
            {
                return (XProcessingInstruction) base.Object_0;
            }
        }
    }
}

