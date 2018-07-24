namespace Newtonsoft.Json.Bson
{
    using ns20;
    using System;
    using System.Runtime.CompilerServices;

    public class BsonObjectId
    {
        [CompilerGenerated]
        private byte[] byte_0;

        public BsonObjectId(byte[] value)
        {
            Class203.smethod_2(value, "value");
            if (value.Length != 12)
            {
                throw new ArgumentException("An ObjectId must be 12 bytes", "value");
            }
            this.Value = value;
        }

        public byte[] Value
        {
            [CompilerGenerated]
            get
            {
                return this.byte_0;
            }
            [CompilerGenerated]
            private set
            {
                this.byte_0 = value;
            }
        }
    }
}

