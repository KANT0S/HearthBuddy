namespace Newtonsoft.Json.Converters
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System;
    using System.Data;

    public class DataTableConverter : JsonConverter
    {
        public override bool CanConvert(Type valueType)
        {
            return typeof(DataTable).IsAssignableFrom(valueType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            DataTable table = existingValue as DataTable;
            if (table == null)
            {
                table = (objectType == typeof(DataTable)) ? new DataTable() : ((DataTable) Activator.CreateInstance(objectType));
            }
            if (reader.JsonToken_0 == JsonToken.PropertyName)
            {
                table.TableName = (string) reader.Object_0;
                reader.Read();
            }
            reader.Read();
            while (reader.JsonToken_0 == JsonToken.StartObject)
            {
                DataRow row = table.NewRow();
                reader.Read();
                while (reader.JsonToken_0 == JsonToken.PropertyName)
                {
                    string name = (string) reader.Object_0;
                    reader.Read();
                    if (!table.Columns.Contains(name))
                    {
                        Type dataType = smethod_0(reader.JsonToken_0);
                        table.Columns.Add(new DataColumn(name, dataType));
                    }
                    row[name] = reader.Object_0 ?? DBNull.Value;
                    reader.Read();
                }
                row.EndEdit();
                table.Rows.Add(row);
                reader.Read();
            }
            return table;
        }

        private static Type smethod_0(JsonToken jsonToken_0)
        {
            switch (jsonToken_0)
            {
                case JsonToken.Integer:
                    return typeof(long);

                case JsonToken.Float:
                    return typeof(double);

                case JsonToken.String:
                case JsonToken.Null:
                case JsonToken.Undefined:
                    return typeof(string);

                case JsonToken.Boolean:
                    return typeof(bool);

                case JsonToken.Date:
                    return typeof(DateTime);
            }
            throw new ArgumentOutOfRangeException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            DataTable table = (DataTable) value;
            DefaultContractResolver resolver = serializer.IContractResolver_0 as DefaultContractResolver;
            writer.WriteStartArray();
            foreach (DataRow row in table.Rows)
            {
                writer.WriteStartObject();
                foreach (DataColumn column in row.Table.Columns)
                {
                    if ((serializer.NullValueHandling_0 != NullValueHandling.Ignore) || ((row[column] != null) && (row[column] != DBNull.Value)))
                    {
                        writer.WritePropertyName((resolver != null) ? resolver.GetResolvedPropertyName(column.ColumnName) : column.ColumnName);
                        serializer.Serialize(writer, row[column]);
                    }
                }
                writer.WriteEndObject();
            }
            writer.WriteEndArray();
        }
    }
}

