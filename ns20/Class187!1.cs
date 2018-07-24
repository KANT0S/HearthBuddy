namespace ns20
{
    using System;

    internal class Class187<T> where T: struct
    {
        private readonly T gparam_0;
        private readonly string string_0;

        public Class187(string name, T value)
        {
            this.string_0 = name;
            this.gparam_0 = value;
        }

        public string Name
        {
            get
            {
                return this.string_0;
            }
        }

        public T Prop_0
        {
            get
            {
                return this.gparam_0;
            }
        }
    }
}

