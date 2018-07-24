namespace JetBrains.Annotations
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Method, AllowMultiple=true, Inherited=true)]
    public sealed class ContractAnnotationAttribute : Attribute
    {
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private string string_0;

        public ContractAnnotationAttribute([NotNull] string fdt) : this(fdt, false)
        {
        }

        public ContractAnnotationAttribute([NotNull] string fdt, bool forceFullStates)
        {
            this.FDT = fdt;
            this.ForceFullStates = forceFullStates;
        }

        public string FDT
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

        public bool ForceFullStates
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_0 = value;
            }
        }
    }
}

