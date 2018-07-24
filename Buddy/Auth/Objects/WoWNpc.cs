namespace Buddy.Auth.Objects
{
    using Buddy.Auth.Math;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    [DataContract(Name="WoWNpc", Namespace="Buddy.Auth.Objects"), KnownType(typeof(Vector3))]
    public class WoWNpc
    {
        [CompilerGenerated]
        private int int_0;
        [CompilerGenerated]
        private int int_1;
        [CompilerGenerated]
        private int int_2;
        [CompilerGenerated]
        private string string_0;
        [CompilerGenerated]
        private string string_1;
        [CompilerGenerated]
        private uint uint_0;
        [CompilerGenerated]
        private uint uint_1;
        [CompilerGenerated]
        private uint uint_2;
        [CompilerGenerated]
        private uint uint_3;
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
                return this.uint_3;
            }
            [CompilerGenerated]
            set
            {
                this.uint_3 = value;
            }
        }

        [DataMember]
        public int Level
        {
            [CompilerGenerated]
            get
            {
                return this.int_2;
            }
            [CompilerGenerated]
            set
            {
                this.int_2 = value;
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
                return this.int_1;
            }
            [CompilerGenerated]
            set
            {
                this.int_1 = value;
            }
        }

        [DataMember]
        public string Name
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
        public uint NpcFlags
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
        public uint NpcFlags2
        {
            [CompilerGenerated]
            get
            {
                return this.uint_2;
            }
            [CompilerGenerated]
            set
            {
                this.uint_2 = value;
            }
        }

        [DataMember]
        public string Title
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

        [DataMember]
        public int TrainerClass
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

