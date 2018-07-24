namespace Buddy.Auth.SR
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Threading;

    [Serializable, DebuggerStepThrough, GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DataContract(Name="r0", Namespace="http://schemas.datacontract.org/2004/07/"), KnownType(typeof(d0))]
    public class r0 : IExtensibleDataObject, INotifyPropertyChanged
    {
        [OptionalField]
        private string BodyField;
        [NonSerialized]
        private ExtensionDataObject extensionDataObject_0;
        [OptionalField]
        private bool SuccessField;

        [field: CompilerGenerated]
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [DataMember]
        public string Body
        {
            get
            {
                return this.BodyField;
            }
            set
            {
                if (this.BodyField != value)
                {
                    this.BodyField = value;
                    this.RaisePropertyChanged("Body");
                }
            }
        }

        [Browsable(false)]
        public ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataObject_0;
            }
            set
            {
                this.extensionDataObject_0 = value;
            }
        }

        [DataMember]
        public bool Success
        {
            get
            {
                return this.SuccessField;
            }
            set
            {
                if (!this.SuccessField.Equals(value))
                {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
                }
            }
        }
    }
}

