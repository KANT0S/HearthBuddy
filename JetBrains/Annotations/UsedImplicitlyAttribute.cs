namespace JetBrains.Annotations
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class UsedImplicitlyAttribute : Attribute
    {
        [CompilerGenerated]
        private ImplicitUseKindFlags implicitUseKindFlags_0;
        [CompilerGenerated]
        private ImplicitUseTargetFlags implicitUseTargetFlags_0;

        [UsedImplicitly]
        public UsedImplicitlyAttribute() : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
        {
        }

        [UsedImplicitly]
        public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags) : this(useKindFlags, ImplicitUseTargetFlags.Default)
        {
        }

        [UsedImplicitly]
        public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags) : this(ImplicitUseKindFlags.Default, targetFlags)
        {
        }

        [UsedImplicitly]
        public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
        {
            this.UseKindFlags = useKindFlags;
            this.TargetFlags = targetFlags;
        }

        [UsedImplicitly]
        public ImplicitUseTargetFlags TargetFlags
        {
            [CompilerGenerated]
            get
            {
                return this.implicitUseTargetFlags_0;
            }
            [CompilerGenerated]
            private set
            {
                this.implicitUseTargetFlags_0 = value;
            }
        }

        [UsedImplicitly]
        public ImplicitUseKindFlags UseKindFlags
        {
            [CompilerGenerated]
            get
            {
                return this.implicitUseKindFlags_0;
            }
            [CompilerGenerated]
            private set
            {
                this.implicitUseKindFlags_0 = value;
            }
        }
    }
}

