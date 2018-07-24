namespace Newtonsoft.Json.Linq
{
    using Newtonsoft.Json;
    using ns18;
    using ns20;
    using System;

    public class JTokenReader : JsonReader, IJsonLineInfo
    {
        private readonly JToken jtoken_0;
        private JToken jtoken_1;
        private JToken jtoken_2;

        public JTokenReader(JToken token)
        {
            Class203.smethod_2(token, "token");
            this.jtoken_0 = token;
            this.jtoken_2 = token;
        }

        private bool method_14(JToken jtoken_3)
        {
            if (jtoken_3 == this.jtoken_0)
            {
                return this.method_15();
            }
            JToken next = jtoken_3.Next;
            if (((next != null) && (next != jtoken_3)) && (jtoken_3 != jtoken_3.Parent.Last))
            {
                this.jtoken_2 = next;
                this.method_19(this.jtoken_2);
                return true;
            }
            if (jtoken_3.Parent == null)
            {
                return this.method_15();
            }
            return this.method_18(jtoken_3.Parent);
        }

        private bool method_15()
        {
            base.SetToken(JsonToken.None);
            return false;
        }

        private JsonToken? method_16(JContainer jcontainer_0)
        {
            switch (jcontainer_0.Type)
            {
                case JTokenType.Object:
                    return 13;

                case JTokenType.Array:
                    return 14;

                case JTokenType.Constructor:
                    return 15;

                case JTokenType.Property:
                    return null;
            }
            throw Class193.smethod_1("Type", jcontainer_0.Type, "Unexpected JContainer type.");
        }

        private bool method_17(JContainer jcontainer_0)
        {
            JToken first = jcontainer_0.First;
            if (first == null)
            {
                return this.method_18(jcontainer_0);
            }
            this.method_19(first);
            this.jtoken_2 = first;
            this.jtoken_1 = jcontainer_0;
            return true;
        }

        private bool method_18(JContainer jcontainer_0)
        {
            JsonToken? nullable = this.method_16(jcontainer_0);
            if (nullable.HasValue)
            {
                base.SetToken(nullable.Value);
                this.jtoken_2 = jcontainer_0;
                this.jtoken_1 = jcontainer_0;
                return true;
            }
            return this.method_14(jcontainer_0);
        }

        private void method_19(JToken jtoken_3)
        {
            switch (jtoken_3.Type)
            {
                case JTokenType.Object:
                    base.SetToken(JsonToken.StartObject);
                    return;

                case JTokenType.Array:
                    base.SetToken(JsonToken.StartArray);
                    return;

                case JTokenType.Constructor:
                    base.SetToken(JsonToken.StartConstructor);
                    return;

                case JTokenType.Property:
                    base.SetToken(JsonToken.PropertyName, ((JProperty) jtoken_3).Name);
                    return;

                case JTokenType.Comment:
                    base.SetToken(JsonToken.Comment, ((JValue) jtoken_3).Value);
                    return;

                case JTokenType.Integer:
                    base.SetToken(JsonToken.Integer, ((JValue) jtoken_3).Value);
                    return;

                case JTokenType.Float:
                    base.SetToken(JsonToken.Float, ((JValue) jtoken_3).Value);
                    return;

                case JTokenType.String:
                    base.SetToken(JsonToken.String, ((JValue) jtoken_3).Value);
                    return;

                case JTokenType.Boolean:
                    base.SetToken(JsonToken.Boolean, ((JValue) jtoken_3).Value);
                    return;

                case JTokenType.Null:
                    base.SetToken(JsonToken.Null, ((JValue) jtoken_3).Value);
                    return;

                case JTokenType.Undefined:
                    base.SetToken(JsonToken.Undefined, ((JValue) jtoken_3).Value);
                    return;

                case JTokenType.Date:
                    base.SetToken(JsonToken.Date, ((JValue) jtoken_3).Value);
                    return;

                case JTokenType.Raw:
                    base.SetToken(JsonToken.Raw, ((JValue) jtoken_3).Value);
                    return;

                case JTokenType.Bytes:
                    base.SetToken(JsonToken.Bytes, ((JValue) jtoken_3).Value);
                    return;

                case JTokenType.Guid:
                    base.SetToken(JsonToken.String, this.method_20(((JValue) jtoken_3).Value));
                    return;

                case JTokenType.Uri:
                    base.SetToken(JsonToken.String, this.method_20(((JValue) jtoken_3).Value));
                    return;

                case JTokenType.TimeSpan:
                    base.SetToken(JsonToken.String, this.method_20(((JValue) jtoken_3).Value));
                    return;
            }
            throw Class193.smethod_1("Type", jtoken_3.Type, "Unexpected JTokenType.");
        }

        private string method_20(object object_1)
        {
            if (object_1 == null)
            {
                return null;
            }
            return object_1.ToString();
        }

        bool IJsonLineInfo.HasLineInfo()
        {
            if (base.CurrentState == JsonReader.State.Start)
            {
                return false;
            }
            IJsonLineInfo info = this.Boolean_0 ? null : this.jtoken_2;
            return ((info != null) && info.HasLineInfo());
        }

        bool JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮()
        {
            if (base.CurrentState != JsonReader.State.Start)
            {
                JContainer container = this.jtoken_2 as JContainer;
                if ((container != null) && (this.jtoken_1 != container))
                {
                    return this.method_17(container);
                }
                return this.method_14(this.jtoken_2);
            }
            this.method_19(this.jtoken_2);
            return true;
        }

        public override bool Read()
        {
            base.enum14_0 = Enum14.Read;
            return this.Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮();
        }

        public override byte[] ReadAsBytes()
        {
            return base.method_5();
        }

        public override DateTime? ReadAsDateTime()
        {
            return base.method_9();
        }

        public override DateTimeOffset? ReadAsDateTimeOffset()
        {
            return base.method_4();
        }

        public override decimal? ReadAsDecimal()
        {
            return base.method_6();
        }

        public override int? ReadAsInt32()
        {
            return base.method_7();
        }

        public override string ReadAsString()
        {
            return base.method_8();
        }

        private bool Boolean_0
        {
            get
            {
                return (this.jtoken_2 == this.jtoken_1);
            }
        }

        int IJsonLineInfo.LineNumber
        {
            get
            {
                if (base.CurrentState != JsonReader.State.Start)
                {
                    IJsonLineInfo info = this.Boolean_0 ? null : this.jtoken_2;
                    if (info != null)
                    {
                        return info.LineNumber;
                    }
                }
                return 0;
            }
        }

        int IJsonLineInfo.LinePosition
        {
            get
            {
                if (base.CurrentState != JsonReader.State.Start)
                {
                    IJsonLineInfo info = this.Boolean_0 ? null : this.jtoken_2;
                    if (info != null)
                    {
                        return info.LinePosition;
                    }
                }
                return 0;
            }
        }
    }
}

