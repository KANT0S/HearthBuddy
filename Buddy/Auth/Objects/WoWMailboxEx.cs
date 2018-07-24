namespace Buddy.Auth.Objects
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    [DataContract(Name="WoWMailboxEx", Namespace="Buddy.Auth.Objects"), KnownType(typeof(WoWMailbox))]
    public class WoWMailboxEx : WoWMailbox
    {
        [CompilerGenerated]
        private uint uint_2;

        [DataMember]
        public uint PlayerCondition
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
    }
}

