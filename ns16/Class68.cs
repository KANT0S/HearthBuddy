namespace ns16
{
    using Newtonsoft.Json;
    using System;
    using System.Globalization;
    using System.IO;

    internal class Class68 : JsonReader, IJsonLineInfo
    {
        private readonly JsonReader jsonReader_0;
        private readonly JsonTextWriter jsonTextWriter_0;
        private readonly StringWriter stringWriter_0;

        public Class68(JsonReader innerReader)
        {
            this.jsonReader_0 = innerReader;
            this.stringWriter_0 = new StringWriter(CultureInfo.InvariantCulture);
            this.jsonTextWriter_0 = new JsonTextWriter(this.stringWriter_0);
            this.jsonTextWriter_0.Formatting = Formatting.Indented;
        }

        public string method_14()
        {
            return this.stringWriter_0.ToString();
        }

        bool IJsonLineInfo.HasLineInfo()
        {
            IJsonLineInfo info = this.jsonReader_0 as IJsonLineInfo;
            return ((info != null) && info.HasLineInfo());
        }

        void JsonReader.Close()
        {
            this.jsonReader_0.Close();
        }

        bool JsonReader.Read()
        {
            bool flag = this.jsonReader_0.Read();
            this.jsonTextWriter_0.method_4(this.jsonReader_0, false, false);
            return flag;
        }

        byte[] JsonReader.ReadAsBytes()
        {
            byte[] buffer = this.jsonReader_0.ReadAsBytes();
            this.jsonTextWriter_0.method_4(this.jsonReader_0, false, false);
            return buffer;
        }

        DateTime? JsonReader.ReadAsDateTime()
        {
            DateTime? nullable = this.jsonReader_0.ReadAsDateTime();
            this.jsonTextWriter_0.method_4(this.jsonReader_0, false, false);
            return nullable;
        }

        DateTimeOffset? JsonReader.ReadAsDateTimeOffset()
        {
            DateTimeOffset? nullable = this.jsonReader_0.ReadAsDateTimeOffset();
            this.jsonTextWriter_0.method_4(this.jsonReader_0, false, false);
            return nullable;
        }

        decimal? JsonReader.ReadAsDecimal()
        {
            decimal? nullable = this.jsonReader_0.ReadAsDecimal();
            this.jsonTextWriter_0.method_4(this.jsonReader_0, false, false);
            return nullable;
        }

        int? JsonReader.ReadAsInt32()
        {
            int? nullable = this.jsonReader_0.ReadAsInt32();
            this.jsonTextWriter_0.method_4(this.jsonReader_0, false, false);
            return nullable;
        }

        string JsonReader.ReadAsString()
        {
            string str = this.jsonReader_0.ReadAsString();
            this.jsonTextWriter_0.method_4(this.jsonReader_0, false, false);
            return str;
        }

        public override char Char_0
        {
            get
            {
                return this.jsonReader_0.Char_0;
            }
            protected internal set
            {
                this.jsonReader_0.Char_0 = value;
            }
        }

        public override int Int32_0
        {
            get
            {
                return this.jsonReader_0.Int32_0;
            }
        }

        public override JsonToken JsonToken_0
        {
            get
            {
                return this.jsonReader_0.JsonToken_0;
            }
        }

        int IJsonLineInfo.LineNumber
        {
            get
            {
                IJsonLineInfo info = this.jsonReader_0 as IJsonLineInfo;
                if (info == null)
                {
                    return 0;
                }
                return info.LineNumber;
            }
        }

        int IJsonLineInfo.LinePosition
        {
            get
            {
                IJsonLineInfo info = this.jsonReader_0 as IJsonLineInfo;
                if (info == null)
                {
                    return 0;
                }
                return info.LinePosition;
            }
        }

        public override object Object_0
        {
            get
            {
                return this.jsonReader_0.Object_0;
            }
        }

        public override string String_0
        {
            get
            {
                return this.jsonReader_0.String_0;
            }
        }

        public override Type Type_0
        {
            get
            {
                return this.jsonReader_0.Type_0;
            }
        }
    }
}

