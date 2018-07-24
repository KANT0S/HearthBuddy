namespace Newtonsoft.Json.Serialization
{
    using System;
    using System.Runtime.CompilerServices;

    public class ErrorContext
    {
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private bool bool_1;
        [CompilerGenerated]
        private Exception exception_0;
        [CompilerGenerated]
        private object object_0;
        [CompilerGenerated]
        private object object_1;
        [CompilerGenerated]
        private string string_0;

        internal ErrorContext(object originalObject, object member, string path, Exception error)
        {
            this.OriginalObject = originalObject;
            this.Member = member;
            this.Error = error;
            this.Path = path;
        }

        internal bool Boolean_0
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

        public Exception Error
        {
            [CompilerGenerated]
            get
            {
                return this.exception_0;
            }
            [CompilerGenerated]
            private set
            {
                this.exception_0 = value;
            }
        }

        public bool Handled
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

        public object Member
        {
            [CompilerGenerated]
            get
            {
                return this.object_1;
            }
            [CompilerGenerated]
            private set
            {
                this.object_1 = value;
            }
        }

        public object OriginalObject
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

        public string Path
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
    }
}

