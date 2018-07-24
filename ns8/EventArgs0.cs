namespace ns8
{
    using System;
    using System.Runtime.CompilerServices;

    internal class EventArgs0 : EventArgs
    {
        [CompilerGenerated]
        private string string_0;

        public EventArgs0(string message)
        {
            this.String_0 = message;
        }

        public string String_0
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

