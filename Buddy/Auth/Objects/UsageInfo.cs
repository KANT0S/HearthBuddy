namespace Buddy.Auth.Objects
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;

    [DataContract(Name="UsageInfo", Namespace="Buddy.Auth.Objects"), KnownType(typeof(TimeSpan))]
    public class UsageInfo
    {
        [CompilerGenerated]
        private string string_0;
        [CompilerGenerated]
        private string string_1;
        [CompilerGenerated]
        private string string_2;
        [CompilerGenerated]
        private string string_3;
        [CompilerGenerated]
        private TimeSpan timeSpan_0;

        public UsageInfo(TimeSpan runTime, string botBase = "", string routine = "", string profile = "")
        {
            this.RunTime = runTime;
            this.BotBase = botBase;
            this.Routine = routine;
            this.Profile = profile;
            this.OsVersion = Environment.OSVersion.VersionString;
        }

        [DataMember]
        public string BotBase
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
        public string OsVersion
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            private set
            {
                this.string_0 = value;
            }
        }

        [DataMember]
        public string Profile
        {
            [CompilerGenerated]
            get
            {
                return this.string_3;
            }
            [CompilerGenerated]
            set
            {
                this.string_3 = value;
            }
        }

        [DataMember]
        public string Routine
        {
            [CompilerGenerated]
            get
            {
                return this.string_2;
            }
            [CompilerGenerated]
            set
            {
                this.string_2 = value;
            }
        }

        [DataMember]
        public TimeSpan RunTime
        {
            [CompilerGenerated]
            get
            {
                return this.timeSpan_0;
            }
            [CompilerGenerated]
            set
            {
                this.timeSpan_0 = value;
            }
        }
    }
}

