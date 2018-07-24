namespace Newtonsoft.Json.Schema
{
    using ns20;
    using System;

    public class ValidationEventArgs : EventArgs
    {
        private readonly JsonSchemaException jsonSchemaException_0;

        internal ValidationEventArgs(JsonSchemaException ex)
        {
            Class203.smethod_2(ex, "ex");
            this.jsonSchemaException_0 = ex;
        }

        public JsonSchemaException Exception
        {
            get
            {
                return this.jsonSchemaException_0;
            }
        }

        public string Message
        {
            get
            {
                return this.jsonSchemaException_0.Message;
            }
        }

        public string Path
        {
            get
            {
                return this.jsonSchemaException_0.Path;
            }
        }
    }
}

