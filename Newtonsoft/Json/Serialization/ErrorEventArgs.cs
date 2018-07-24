namespace Newtonsoft.Json.Serialization
{
    using System;
    using System.Runtime.CompilerServices;

    public class ErrorEventArgs : EventArgs
    {
        [CompilerGenerated]
        private Newtonsoft.Json.Serialization.ErrorContext errorContext_0;
        [CompilerGenerated]
        private object object_0;

        public ErrorEventArgs(object currentObject, Newtonsoft.Json.Serialization.ErrorContext errorContext)
        {
            this.CurrentObject = currentObject;
            this.ErrorContext = errorContext;
        }

        public object CurrentObject
        {
            [CompilerGenerated]
            get
            {
                return this.object_0;
            }
            [CompilerGenerated]
            private set
            {
                this.object_0 = value;
            }
        }

        public Newtonsoft.Json.Serialization.ErrorContext ErrorContext
        {
            [CompilerGenerated]
            get
            {
                return this.errorContext_0;
            }
            [CompilerGenerated]
            private set
            {
                this.errorContext_0 = value;
            }
        }
    }
}

