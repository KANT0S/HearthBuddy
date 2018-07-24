namespace Buddy.Auth.Objects
{
    using Buddy.Auth.Math;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    [DataContract(Name="WoWMailbox", Namespace="Buddy.Auth.Objects"), KnownType(typeof(Vector3))]
    public class WoWMailbox
    {
        [CompilerGenerated]
        private int int_0;
        [CompilerGenerated]
        private uint uint_0;
        [CompilerGenerated]
        private uint uint_1;
        [CompilerGenerated]
        private Vector3 vector3_0;

        [DataMember]
        public uint Entry
        {
            [CompilerGenerated]
            get
            {
                return this.uint_0;
            }
            [CompilerGenerated]
            set
            {
                this.uint_0 = value;
            }
        }

        [DataMember]
        public uint FactionId
        {
            [CompilerGenerated]
            get
            {
                return this.uint_1;
            }
            [CompilerGenerated]
            set
            {
                this.uint_1 = value;
            }
        }

        [DataMember]
        public Vector3 Location
        {
            [CompilerGenerated]
            get
            {
                return this.vector3_0;
            }
            [CompilerGenerated]
            set
            {
                this.vector3_0 = value;
            }
        }

        [DataMember]
        public int MapId
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
    }
}

