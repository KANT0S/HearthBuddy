namespace Buddy.Auth.Objects
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    [DataContract(Name="StoreProduct", Namespace="Buddy.Auth.Objects")]
    public class StoreProduct
    {
        [CompilerGenerated]
        private byte[] byte_0;
        [CompilerGenerated]
        private int int_0;
        [CompilerGenerated]
        private string string_0;
        [CompilerGenerated]
        private string string_1;

        [DataMember]
        public byte[] Data
        {
            [CompilerGenerated]
            get
            {
                return this.byte_0;
            }
            [CompilerGenerated]
            set
            {
                this.byte_0 = value;
            }
        }

        [DataMember]
        public string ProductName
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            set
            {
                this.string_0 = value;
            }
        }

        [DataMember]
        public int ProductType
        {
            [CompilerGenerated]
            get
            {
                return this.int_0;
            }
            [CompilerGenerated]
            set
            {
                this.int_0 = value;
            }
        }

        [DataMember]
        public string Version
        {
            [CompilerGenerated]
            get
            {
                return this.string_1;
            }
            [CompilerGenerated]
            set
            {
                this.string_1 = value;
            }
        }
    }
}

