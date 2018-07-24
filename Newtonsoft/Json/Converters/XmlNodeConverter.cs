namespace Newtonsoft.Json.Converters
{
    using Newtonsoft.Json;
    using ns17;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Xml;
    using System.Xml.Linq;

    public class XmlNodeConverter : JsonConverter
    {
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private bool bool_1;
        [CompilerGenerated]
        private static Func<Interface10, bool> func_0;
        [CompilerGenerated]
        private static Func<Interface10, bool> func_1;
        private const string string_0 = "#text";
        private const string string_1 = "#comment";
        private const string string_2 = "#cdata-section";
        private const string string_3 = "#whitespace";
        private const string string_4 = "#significant-whitespace";
        private const string string_5 = "?xml";
        private const string string_6 = "http://james.newtonking.com/projects/json";
        [CompilerGenerated]
        private string string_7;

        public override bool CanConvert(Type valueType)
        {
            return (typeof(XObject).IsAssignableFrom(valueType) || typeof(System.Xml.XmlNode).IsAssignableFrom(valueType));
        }

        private Interface10 method_0(object object_0)
        {
            if (object_0 is XObject)
            {
                return Class98.smethod_0((XObject) object_0);
            }
            if (!(object_0 is System.Xml.XmlNode))
            {
                throw new ArgumentException("Value must be an XML object.", "value");
            }
            return new Class92((System.Xml.XmlNode) object_0);
        }

        private void method_1(Interface10 interface10_0, XmlNamespaceManager xmlNamespaceManager_0)
        {
            List<Interface10> list = null;
            Interface10 item = interface10_0;
            while ((item = item.Interface10_0) != null)
            {
                if (item.XmlNodeType_0 == XmlNodeType.Element)
                {
                    if (list == null)
                    {
                        list = new List<Interface10>();
                    }
                    list.Add(item);
                }
            }
            if (list != null)
            {
                list.Reverse();
                foreach (Interface10 interface3 in list)
                {
                    xmlNamespaceManager_0.PushScope();
                    foreach (Interface10 interface4 in interface3.Prop_1)
                    {
                        if ((interface4.String_2 == "http://www.w3.org/2000/xmlns/") && (interface4.String_0 != "xmlns"))
                        {
                            xmlNamespaceManager_0.AddNamespace(interface4.String_0, interface4.String_1);
                        }
                    }
                }
            }
        }

        private void method_10(JsonReader jsonReader_0, Interface11 interface11_0, string string_8, Interface10 interface10_0, XmlNamespaceManager xmlNamespaceManager_0)
        {
            Func<Interface12, bool> predicate = null;
            Class106 class2 = new Class106 {
                string_0 = string_8
            };
            string str = Class193.smethod_4(class2.string_0);
            Interface12 interface2 = this.method_14(class2.string_0, interface11_0, str, xmlNamespaceManager_0);
            interface10_0.imethod_0(interface2);
            int num = 0;
            while (jsonReader_0.Read())
            {
                if (jsonReader_0.JsonToken_0 == JsonToken.EndArray)
                {
                    break;
                }
                this.method_7(jsonReader_0, interface11_0, xmlNamespaceManager_0, class2.string_0, interface2);
                num++;
            }
            if (this.WriteArrayAttribute)
            {
                this.method_11(interface2, interface11_0);
            }
            if ((num == 1) && this.WriteArrayAttribute)
            {
                if (predicate == null)
                {
                    predicate = new Func<Interface12, bool>(class2.method_0);
                }
                Interface12 interface3 = interface2.Prop_0.OfType<Interface12>().Single<Interface12>(predicate);
                this.method_11(interface3, interface11_0);
            }
        }

        private void method_11(Interface12 interface12_0, Interface11 interface11_0)
        {
            interface12_0.imethod_1(interface11_0.imethod_11("json:Array", "http://james.newtonking.com/projects/json", "true"));
            if ((interface12_0 is Class100) && (interface12_0.imethod_2("http://james.newtonking.com/projects/json") == null))
            {
                interface12_0.imethod_1(interface11_0.imethod_11("xmlns:json", "http://www.w3.org/2000/xmlns/", "http://james.newtonking.com/projects/json"));
            }
        }

        private Dictionary<string, string> method_12(JsonReader jsonReader_0, XmlNamespaceManager xmlNamespaceManager_0)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            bool flag = false;
            bool flag2 = false;
            if ((((jsonReader_0.JsonToken_0 == JsonToken.String) || (jsonReader_0.JsonToken_0 == JsonToken.Null)) || ((jsonReader_0.JsonToken_0 == JsonToken.Boolean) || (jsonReader_0.JsonToken_0 == JsonToken.Integer))) || (((jsonReader_0.JsonToken_0 == JsonToken.Float) || (jsonReader_0.JsonToken_0 == JsonToken.Date)) || (jsonReader_0.JsonToken_0 == JsonToken.StartConstructor)))
            {
                return dictionary;
            }
        Label_01BC:
            if (flag)
            {
                return dictionary;
            }
            if (flag2 || !jsonReader_0.Read())
            {
                return dictionary;
            }
            JsonToken token = jsonReader_0.JsonToken_0;
            if (token != JsonToken.PropertyName)
            {
                if (token != JsonToken.EndObject)
                {
                    throw new JsonSerializationException("Unexpected JsonToken: " + jsonReader_0.JsonToken_0);
                }
                flag2 = true;
            }
            else
            {
                string str = jsonReader_0.Object_0.ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    string str2;
                    switch (str[0])
                    {
                        case '$':
                        {
                            str = str.Substring(1);
                            jsonReader_0.Read();
                            str2 = jsonReader_0.Object_0.ToString();
                            string prefix = xmlNamespaceManager_0.LookupPrefix("http://james.newtonking.com/projects/json");
                            if (prefix == null)
                            {
                                int? nullable = null;
                                while (xmlNamespaceManager_0.LookupNamespace("json" + nullable) != null)
                                {
                                    nullable = new int?(nullable.GetValueOrDefault() + 1);
                                }
                                prefix = "json" + nullable;
                                dictionary.Add("xmlns:" + prefix, "http://james.newtonking.com/projects/json");
                                xmlNamespaceManager_0.AddNamespace(prefix, "http://james.newtonking.com/projects/json");
                            }
                            dictionary.Add(prefix + ":" + str, str2);
                            goto Label_01BC;
                        }
                        case '@':
                            string str3;
                            str = str.Substring(1);
                            jsonReader_0.Read();
                            str2 = this.method_9(jsonReader_0);
                            dictionary.Add(str, str2);
                            if (this.method_16(str, out str3))
                            {
                                xmlNamespaceManager_0.AddNamespace(str3, str2);
                            }
                            goto Label_01BC;
                    }
                    flag = true;
                }
                else
                {
                    flag = true;
                }
            }
            goto Label_01BC;
        }

        private void method_13(JsonReader jsonReader_0, Interface11 interface11_0, Interface10 interface10_0, string string_8)
        {
            if (!(string_8 == "?xml"))
            {
                Interface10 interface3 = interface11_0.imethod_7(string_8.Substring(1), jsonReader_0.Object_0.ToString());
                interface10_0.imethod_0(interface3);
            }
            else
            {
                string str = null;
                string str2 = null;
                string str3 = null;
                while (true)
                {
                    if (!jsonReader_0.Read() || (jsonReader_0.JsonToken_0 == JsonToken.EndObject))
                    {
                        Interface10 interface2 = interface11_0.imethod_6(str, str2, str3);
                        interface10_0.imethod_0(interface2);
                        return;
                    }
                    string str4 = jsonReader_0.Object_0.ToString();
                    if (str4 == null)
                    {
                        break;
                    }
                    if (str4 != "@version")
                    {
                        if (!(str4 == "@encoding"))
                        {
                            if (!(str4 == "@standalone"))
                            {
                                break;
                            }
                            jsonReader_0.Read();
                            str3 = jsonReader_0.Object_0.ToString();
                        }
                        else
                        {
                            jsonReader_0.Read();
                            str2 = jsonReader_0.Object_0.ToString();
                        }
                    }
                    else
                    {
                        jsonReader_0.Read();
                        str = jsonReader_0.Object_0.ToString();
                    }
                }
                throw new JsonSerializationException("Unexpected property name encountered while deserializing XmlDeclaration: " + jsonReader_0.Object_0);
            }
        }

        private Interface12 method_14(string string_8, Interface11 interface11_0, string string_9, XmlNamespaceManager xmlNamespaceManager_0)
        {
            string str = string.IsNullOrEmpty(string_9) ? xmlNamespaceManager_0.DefaultNamespace : xmlNamespaceManager_0.LookupNamespace(string_9);
            return (!string.IsNullOrEmpty(str) ? interface11_0.imethod_9(string_8, str) : interface11_0.imethod_8(string_8));
        }

        private void method_15(JsonReader jsonReader_0, Interface11 interface11_0, XmlNamespaceManager xmlNamespaceManager_0, Interface10 interface10_0)
        {
            string str;
            Func<Interface12, bool> func;
        Label_0000:
            func = null;
            Class107 class2 = new Class107();
            JsonToken token = jsonReader_0.JsonToken_0;
            switch (token)
            {
                case JsonToken.StartConstructor:
                    str = jsonReader_0.Object_0.ToString();
                    goto Label_0140;

                case JsonToken.PropertyName:
                {
                    if ((interface10_0.XmlNodeType_0 == XmlNodeType.Document) && (interface11_0.Interface12_0 != null))
                    {
                        throw new JsonSerializationException("JSON root object has multiple properties. The root object must have a single property in order to create a valid XML document. Consider specifing a DeserializeRootElementName.");
                    }
                    class2.string_0 = jsonReader_0.Object_0.ToString();
                    jsonReader_0.Read();
                    if (jsonReader_0.JsonToken_0 != JsonToken.StartArray)
                    {
                        this.method_7(jsonReader_0, interface11_0, xmlNamespaceManager_0, class2.string_0, interface10_0);
                        break;
                    }
                    int num = 0;
                    while (jsonReader_0.Read())
                    {
                        if (jsonReader_0.JsonToken_0 == JsonToken.EndArray)
                        {
                            break;
                        }
                        this.method_7(jsonReader_0, interface11_0, xmlNamespaceManager_0, class2.string_0, interface10_0);
                        num++;
                    }
                    if ((num == 1) && this.WriteArrayAttribute)
                    {
                        if (func == null)
                        {
                            func = new Func<Interface12, bool>(class2.method_0);
                        }
                        Interface12 interface2 = interface10_0.Prop_0.OfType<Interface12>().Single<Interface12>(func);
                        this.method_11(interface2, interface11_0);
                    }
                    break;
                }
                case JsonToken.Comment:
                    interface10_0.imethod_0(interface11_0.imethod_1((string) jsonReader_0.Object_0));
                    break;

                default:
                    switch (token)
                    {
                        case JsonToken.EndObject:
                        case JsonToken.EndArray:
                            return;
                    }
                    throw new JsonSerializationException("Unexpected JsonToken when deserializing node: " + jsonReader_0.JsonToken_0);
            }
        Label_0044:
            if ((jsonReader_0.JsonToken_0 == JsonToken.PropertyName) || jsonReader_0.Read())
            {
                goto Label_0000;
            }
            return;
        Label_0140:
            if (!jsonReader_0.Read() || (jsonReader_0.JsonToken_0 == JsonToken.EndConstructor))
            {
                goto Label_0044;
            }
            this.method_7(jsonReader_0, interface11_0, xmlNamespaceManager_0, str, interface10_0);
            goto Label_0140;
        }

        private bool method_16(string string_8, out string string_9)
        {
            if (string_8.StartsWith("xmlns", StringComparison.Ordinal))
            {
                if (string_8.Length == 5)
                {
                    string_9 = string.Empty;
                    return true;
                }
                if (string_8[5] == ':')
                {
                    string_9 = string_8.Substring(6, string_8.Length - 6);
                    return true;
                }
            }
            string_9 = null;
            return false;
        }

        private IEnumerable<Interface10> method_17(IEnumerable<Interface10> ienumerable_0)
        {
            if (func_1 == null)
            {
                func_1 = new Func<Interface10, bool>(XmlNodeConverter.smethod_1);
            }
            return ienumerable_0.Where<Interface10>(func_1);
        }

        private string method_2(Interface10 interface10_0, XmlNamespaceManager xmlNamespaceManager_0)
        {
            string str = ((interface10_0.String_2 == null) || ((interface10_0.String_0 == "xmlns") && (interface10_0.String_2 == "http://www.w3.org/2000/xmlns/"))) ? null : xmlNamespaceManager_0.LookupPrefix(interface10_0.String_2);
            if (!string.IsNullOrEmpty(str))
            {
                return (str + ":" + interface10_0.String_0);
            }
            return interface10_0.String_0;
        }

        private string method_3(Interface10 interface10_0, XmlNamespaceManager xmlNamespaceManager_0)
        {
            switch (interface10_0.XmlNodeType_0)
            {
                case XmlNodeType.Element:
                    return this.method_2(interface10_0, xmlNamespaceManager_0);

                case XmlNodeType.Attribute:
                    if (!(interface10_0.String_2 == "http://james.newtonking.com/projects/json"))
                    {
                        return ("@" + this.method_2(interface10_0, xmlNamespaceManager_0));
                    }
                    return ("$" + interface10_0.String_0);

                case XmlNodeType.Text:
                    return "#text";

                case XmlNodeType.CDATA:
                    return "#cdata-section";

                case XmlNodeType.ProcessingInstruction:
                    return ("?" + this.method_2(interface10_0, xmlNamespaceManager_0));

                case XmlNodeType.Comment:
                    return "#comment";

                case XmlNodeType.Whitespace:
                    return "#whitespace";

                case XmlNodeType.SignificantWhitespace:
                    return "#significant-whitespace";

                case XmlNodeType.XmlDeclaration:
                    return "?xml";
            }
            throw new JsonSerializationException("Unexpected XmlNodeType when getting node name: " + interface10_0.XmlNodeType_0);
        }

        private bool method_4(Interface10 interface10_0)
        {
            if (func_0 == null)
            {
                func_0 = new Func<Interface10, bool>(XmlNodeConverter.smethod_0);
            }
            Interface10 interface2 = (interface10_0.Prop_1 != null) ? interface10_0.Prop_1.SingleOrDefault<Interface10>(func_0) : null;
            return ((interface2 != null) && XmlConvert.ToBoolean(interface2.String_1));
        }

        private void method_5(JsonWriter jsonWriter_0, Interface10 interface10_0, XmlNamespaceManager xmlNamespaceManager_0, bool bool_2)
        {
            Dictionary<string, List<Interface10>> dictionary = new Dictionary<string, List<Interface10>>();
            for (int i = 0; i < interface10_0.Prop_0.Count; i++)
            {
                List<Interface10> list;
                Interface10 interface2 = interface10_0.Prop_0[i];
                string key = this.method_3(interface2, xmlNamespaceManager_0);
                if (!dictionary.TryGetValue(key, out list))
                {
                    list = new List<Interface10>();
                    dictionary.Add(key, list);
                }
                list.Add(interface2);
            }
            foreach (KeyValuePair<string, List<Interface10>> pair in dictionary)
            {
                bool flag;
                List<Interface10> list2 = pair.Value;
                if (list2.Count == 1)
                {
                    flag = this.method_4(list2[0]);
                }
                else
                {
                    flag = true;
                }
                if (!flag)
                {
                    this.method_6(jsonWriter_0, list2[0], xmlNamespaceManager_0, bool_2);
                }
                else
                {
                    string name = pair.Key;
                    if (bool_2)
                    {
                        jsonWriter_0.WritePropertyName(name);
                    }
                    jsonWriter_0.WriteStartArray();
                    for (int j = 0; j < list2.Count; j++)
                    {
                        this.method_6(jsonWriter_0, list2[j], xmlNamespaceManager_0, false);
                    }
                    jsonWriter_0.WriteEndArray();
                }
            }
        }

        private void method_6(JsonWriter jsonWriter_0, Interface10 interface10_0, XmlNamespaceManager xmlNamespaceManager_0, bool bool_2)
        {
            Func<Interface10, bool> predicate = null;
            Class105 class2 = new Class105 {
                interface10_0 = interface10_0
            };
            switch (class2.interface10_0.XmlNodeType_0)
            {
                case XmlNodeType.Element:
                    if (this.method_4(class2.interface10_0))
                    {
                        if (predicate == null)
                        {
                            predicate = new Func<Interface10, bool>(class2.method_0);
                        }
                        if (class2.interface10_0.Prop_0.All<Interface10>(predicate) && (class2.interface10_0.Prop_0.Count > 0))
                        {
                            this.method_5(jsonWriter_0, class2.interface10_0, xmlNamespaceManager_0, false);
                            return;
                        }
                    }
                    xmlNamespaceManager_0.PushScope();
                    foreach (Interface10 interface2 in class2.interface10_0.Prop_1)
                    {
                        if (interface2.String_2 == "http://www.w3.org/2000/xmlns/")
                        {
                            string prefix = (interface2.String_0 != "xmlns") ? interface2.String_0 : string.Empty;
                            string uri = interface2.String_1;
                            xmlNamespaceManager_0.AddNamespace(prefix, uri);
                        }
                    }
                    if (bool_2)
                    {
                        jsonWriter_0.WritePropertyName(this.method_3(class2.interface10_0, xmlNamespaceManager_0));
                    }
                    if ((!this.method_17(class2.interface10_0.Prop_1).Any<Interface10>() && (class2.interface10_0.Prop_0.Count == 1)) && (class2.interface10_0.Prop_0[0].XmlNodeType_0 == XmlNodeType.Text))
                    {
                        jsonWriter_0.WriteValue(class2.interface10_0.Prop_0[0].String_1);
                    }
                    else if ((class2.interface10_0.Prop_0.Count == 0) && Class191.smethod_0<Interface10>(class2.interface10_0.Prop_1))
                    {
                        jsonWriter_0.WriteNull();
                    }
                    else
                    {
                        jsonWriter_0.WriteStartObject();
                        for (int i = 0; i < class2.interface10_0.Prop_1.Count; i++)
                        {
                            this.method_6(jsonWriter_0, class2.interface10_0.Prop_1[i], xmlNamespaceManager_0, true);
                        }
                        this.method_5(jsonWriter_0, class2.interface10_0, xmlNamespaceManager_0, true);
                        jsonWriter_0.WriteEndObject();
                    }
                    xmlNamespaceManager_0.PopScope();
                    return;

                case XmlNodeType.Attribute:
                case XmlNodeType.Text:
                case XmlNodeType.CDATA:
                case XmlNodeType.ProcessingInstruction:
                case XmlNodeType.Whitespace:
                case XmlNodeType.SignificantWhitespace:
                    if (!(class2.interface10_0.String_2 == "http://www.w3.org/2000/xmlns/") || !(class2.interface10_0.String_1 == "http://james.newtonking.com/projects/json"))
                    {
                        if ((class2.interface10_0.String_2 != "http://james.newtonking.com/projects/json") || (class2.interface10_0.String_0 != "Array"))
                        {
                            if (bool_2)
                            {
                                jsonWriter_0.WritePropertyName(this.method_3(class2.interface10_0, xmlNamespaceManager_0));
                            }
                            jsonWriter_0.WriteValue(class2.interface10_0.String_1);
                        }
                        return;
                    }
                    return;

                case XmlNodeType.Comment:
                    if (bool_2)
                    {
                        jsonWriter_0.WriteComment(class2.interface10_0.String_1);
                    }
                    return;

                case XmlNodeType.Document:
                case XmlNodeType.DocumentFragment:
                    this.method_5(jsonWriter_0, class2.interface10_0, xmlNamespaceManager_0, bool_2);
                    return;

                case XmlNodeType.XmlDeclaration:
                {
                    Interface13 interface3 = (Interface13) class2.interface10_0;
                    jsonWriter_0.WritePropertyName(this.method_3(class2.interface10_0, xmlNamespaceManager_0));
                    jsonWriter_0.WriteStartObject();
                    if (!string.IsNullOrEmpty(interface3.String_3))
                    {
                        jsonWriter_0.WritePropertyName("@version");
                        jsonWriter_0.WriteValue(interface3.String_3);
                    }
                    if (!string.IsNullOrEmpty(interface3.String_4))
                    {
                        jsonWriter_0.WritePropertyName("@encoding");
                        jsonWriter_0.WriteValue(interface3.String_4);
                    }
                    if (!string.IsNullOrEmpty(interface3.String_5))
                    {
                        jsonWriter_0.WritePropertyName("@standalone");
                        jsonWriter_0.WriteValue(interface3.String_5);
                    }
                    jsonWriter_0.WriteEndObject();
                    return;
                }
            }
            throw new JsonSerializationException("Unexpected XmlNodeType when serializing nodes: " + class2.interface10_0.XmlNodeType_0);
        }

        private void method_7(JsonReader jsonReader_0, Interface11 interface11_0, XmlNamespaceManager xmlNamespaceManager_0, string string_8, Interface10 interface10_0)
        {
            switch (string_8)
            {
                case "#text":
                    interface10_0.imethod_0(interface11_0.imethod_2(jsonReader_0.Object_0.ToString()));
                    return;

                case "#cdata-section":
                    interface10_0.imethod_0(interface11_0.imethod_3(jsonReader_0.Object_0.ToString()));
                    return;

                case "#whitespace":
                    interface10_0.imethod_0(interface11_0.imethod_4(jsonReader_0.Object_0.ToString()));
                    return;

                case "#significant-whitespace":
                    interface10_0.imethod_0(interface11_0.imethod_5(jsonReader_0.Object_0.ToString()));
                    return;
            }
            if (!string.IsNullOrEmpty(string_8) && (string_8[0] == '?'))
            {
                this.method_13(jsonReader_0, interface11_0, interface10_0, string_8);
            }
            else if (jsonReader_0.JsonToken_0 == JsonToken.StartArray)
            {
                this.method_10(jsonReader_0, interface11_0, string_8, interface10_0, xmlNamespaceManager_0);
            }
            else
            {
                this.method_8(jsonReader_0, interface11_0, interface10_0, string_8, xmlNamespaceManager_0);
            }
        }

        private void method_8(JsonReader jsonReader_0, Interface11 interface11_0, Interface10 interface10_0, string string_8, XmlNamespaceManager xmlNamespaceManager_0)
        {
            if (string.IsNullOrEmpty(string_8))
            {
                throw new JsonSerializationException("XmlNodeConverter cannot convert JSON with an empty property name to XML.");
            }
            Dictionary<string, string> dictionary = this.method_12(jsonReader_0, xmlNamespaceManager_0);
            string str = Class193.smethod_4(string_8);
            if (string_8.StartsWith("@"))
            {
                string str2 = string_8.Substring(1);
                string str3 = jsonReader_0.Object_0.ToString();
                string str4 = Class193.smethod_4(str2);
                Interface10 interface2 = !string.IsNullOrEmpty(str4) ? interface11_0.imethod_11(str2, xmlNamespaceManager_0.LookupNamespace(str4), str3) : interface11_0.imethod_10(str2, str3);
                ((Interface12) interface10_0).imethod_1(interface2);
            }
            else
            {
                Interface12 interface3 = this.method_14(string_8, interface11_0, str, xmlNamespaceManager_0);
                interface10_0.imethod_0(interface3);
                foreach (KeyValuePair<string, string> pair in dictionary)
                {
                    string str5 = Class193.smethod_4(pair.Key);
                    Interface10 interface4 = !string.IsNullOrEmpty(str5) ? interface11_0.imethod_11(pair.Key, xmlNamespaceManager_0.LookupNamespace(str5), pair.Value) : interface11_0.imethod_10(pair.Key, pair.Value);
                    interface3.imethod_1(interface4);
                }
                if ((((jsonReader_0.JsonToken_0 != JsonToken.String) && (jsonReader_0.JsonToken_0 != JsonToken.Integer)) && ((jsonReader_0.JsonToken_0 != JsonToken.Float) && (jsonReader_0.JsonToken_0 != JsonToken.Boolean))) && (jsonReader_0.JsonToken_0 != JsonToken.Date))
                {
                    if ((jsonReader_0.JsonToken_0 != JsonToken.Null) && (jsonReader_0.JsonToken_0 != JsonToken.EndObject))
                    {
                        xmlNamespaceManager_0.PushScope();
                        this.method_15(jsonReader_0, interface11_0, xmlNamespaceManager_0, interface3);
                        xmlNamespaceManager_0.PopScope();
                    }
                }
                else
                {
                    interface3.imethod_0(interface11_0.imethod_2(this.method_9(jsonReader_0)));
                }
            }
        }

        private string method_9(JsonReader jsonReader_0)
        {
            if (jsonReader_0.JsonToken_0 == JsonToken.String)
            {
                return jsonReader_0.Object_0.ToString();
            }
            if (jsonReader_0.JsonToken_0 == JsonToken.Integer)
            {
                return XmlConvert.ToString(Convert.ToInt64(jsonReader_0.Object_0, CultureInfo.InvariantCulture));
            }
            if (jsonReader_0.JsonToken_0 == JsonToken.Float)
            {
                return XmlConvert.ToString(Convert.ToDouble(jsonReader_0.Object_0, CultureInfo.InvariantCulture));
            }
            if (jsonReader_0.JsonToken_0 == JsonToken.Boolean)
            {
                return XmlConvert.ToString(Convert.ToBoolean(jsonReader_0.Object_0, CultureInfo.InvariantCulture));
            }
            if (jsonReader_0.JsonToken_0 == JsonToken.Date)
            {
                DateTime time = Convert.ToDateTime(jsonReader_0.Object_0, CultureInfo.InvariantCulture);
                return XmlConvert.ToString(time, Class184.smethod_1(time.Kind));
            }
            if (jsonReader_0.JsonToken_0 != JsonToken.Null)
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Cannot get an XML string value from token type '{0}'.".smethod_0(CultureInfo.InvariantCulture, jsonReader_0.JsonToken_0));
            }
            return null;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.JsonToken_0 == JsonToken.Null)
            {
                return null;
            }
            XmlNamespaceManager manager = new XmlNamespaceManager(new NameTable());
            Interface11 interface2 = null;
            Interface10 interface3 = null;
            if (typeof(XObject).IsAssignableFrom(objectType))
            {
                if ((objectType != typeof(XDocument)) && (objectType != typeof(XElement)))
                {
                    throw new JsonSerializationException("XmlNodeConverter only supports deserializing XDocument or XElement.");
                }
                XDocument document = new XDocument();
                interface2 = new Class99(document);
                interface3 = interface2;
            }
            if (typeof(System.Xml.XmlNode).IsAssignableFrom(objectType))
            {
                if (objectType != typeof(XmlDocument))
                {
                    throw new JsonSerializationException("XmlNodeConverter only supports deserializing XmlDocuments");
                }
                XmlDocument document2 = new XmlDocument();
                interface2 = new Class93(document2);
                interface3 = interface2;
            }
            if ((interface2 == null) || (interface3 == null))
            {
                throw new JsonSerializationException("Unexpected type when converting XML: " + objectType);
            }
            if (reader.JsonToken_0 != JsonToken.StartObject)
            {
                throw new JsonSerializationException("XmlNodeConverter can only convert JSON that begins with an object.");
            }
            if (!string.IsNullOrEmpty(this.DeserializeRootElementName))
            {
                this.method_8(reader, interface2, interface3, this.DeserializeRootElementName, manager);
            }
            else
            {
                reader.Read();
                this.method_15(reader, interface2, manager, interface3);
            }
            if (!(objectType == typeof(XElement)))
            {
                return interface2.Object_0;
            }
            XElement element = (XElement) interface2.Interface12_0.Object_0;
            element.Remove();
            return element;
        }

        [CompilerGenerated]
        private static bool smethod_0(Interface10 interface10_0)
        {
            return ((interface10_0.String_0 == "Array") && (interface10_0.String_2 == "http://james.newtonking.com/projects/json"));
        }

        [CompilerGenerated]
        private static bool smethod_1(Interface10 interface10_0)
        {
            return (interface10_0.String_2 != "http://james.newtonking.com/projects/json");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Interface10 interface2 = this.method_0(value);
            XmlNamespaceManager manager = new XmlNamespaceManager(new NameTable());
            this.method_1(interface2, manager);
            if (!this.OmitRootObject)
            {
                writer.WriteStartObject();
            }
            this.method_6(writer, interface2, manager, !this.OmitRootObject);
            if (!this.OmitRootObject)
            {
                writer.WriteEndObject();
            }
        }

        public string DeserializeRootElementName
        {
            [CompilerGenerated]
            get
            {
                return this.string_7;
            }
            [CompilerGenerated]
            set
            {
                this.string_7 = value;
            }
        }

        public bool OmitRootObject
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

        public bool WriteArrayAttribute
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

        [CompilerGenerated]
        private sealed class Class105
        {
            public Interface10 interface10_0;

            public bool method_0(Interface10 interface10_1)
            {
                return (interface10_1.String_0 == this.interface10_0.String_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class106
        {
            public string string_0;

            public bool method_0(Interface12 interface12_0)
            {
                return (interface12_0.String_0 == this.string_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class107
        {
            public string string_0;

            public bool method_0(Interface12 interface12_0)
            {
                return (interface12_0.String_0 == this.string_0);
            }
        }
    }
}

