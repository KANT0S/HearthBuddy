namespace Buddy.Auth.SR
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.Runtime.Serialization;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name="d0", Namespace="http://schemas.datacontract.org/2004/07/")]
    public class d0 : r0
    {
        [OptionalField]
        private byte[] DataField;
        [OptionalField]
        private string InfoField;

        [DataMember]
        public byte[] Data
        {
            get
            {
                return this.DataField;
            }
            set
            {
                if (this.DataField != value)
                {
                    this.DataField = value;
                    base.RaisePropertyChanged("Data");
                }
            }
        }

        [DataMember]
        public string Info
        {
            get
            {
                return this.InfoField;
            }
            set
            {
                if (this.InfoField != value)
                {
                    this.InfoField = value;
                    base.RaisePropertyChanged("Info");
                }
            }
        }
    }
}

