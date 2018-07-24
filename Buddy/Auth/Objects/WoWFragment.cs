namespace Buddy.Auth.Objects
{
    using Buddy.Auth.Math;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    [DataContract(Name="WoWFragment", Namespace="Buddy.Auth.Objects"), KnownType(typeof(Vector3))]
    public class WoWFragment
    {
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private bool bool_1;
        [CompilerGenerated]
        private string string_0;
        [CompilerGenerated]
        private uint uint_0;
        [CompilerGenerated]
        private Vector3 vector3_0;

        [DataMember]
        public uint DigsiteId
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
        public bool HigherZExists
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            set
            {
                this.bool_0 = value;
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
        public bool Outdoors
        {
            [CompilerGenerated]
            get
            {
                return this.bool_1;
            }
            [CompilerGenerated]
            set
            {
                this.bool_1 = value;
            }
        }

        [DataMember]
        public string Type
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
    }
}

