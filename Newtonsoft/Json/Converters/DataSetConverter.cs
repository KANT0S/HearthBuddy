namespace Newtonsoft.Json.Converters
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System;
    using System.Data;

    public class DataSetConverter : JsonConverter
    {
        public override bool CanConvert(Type valueType)
        {
            return typeof(DataSet).IsAssignableFrom(valueType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            DataSet set = (objectType == typeof(DataSet)) ? new DataSet() : ((DataSet) Activator.CreateInstance(objectType));
            DataTableConverter converter = new DataTableConverter();
            reader.Read();
            while (reader.JsonToken_0 == JsonToken.PropertyName)
            {
                DataTable table = set.Tables[(string) reader.Object_0];
                bool flag = table != null;
                table = (DataTable) converter.ReadJson(reader, typeof(DataTable), table, serializer);
                if (!flag)
                {
                    set.Tables.Add(table);
                }
                reader.Read();
            }
            return set;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            DataSet set = (DataSet) value;
            DefaultContractResolver resolver = serializer.IContractResolver_0 as DefaultContractResolver;
            DataTableConverter converter = new DataTableConverter();
            writer.WriteStartObject();
            foreach (DataTable table in set.Tables)
            {
                writer.WritePropertyName((resolver != null) ? resolver.GetResolvedPropertyName(table.TableName) : table.TableName);
                converter.WriteJson(writer, table, serializer);
            }
            writer.WriteEndObject();
        }
    }
}

