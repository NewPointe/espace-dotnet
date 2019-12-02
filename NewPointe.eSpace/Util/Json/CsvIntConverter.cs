using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class CsvIntConverter : JsonConverter<int[]>
{

    public override void WriteJson(JsonWriter writer, int[] value, JsonSerializer serializer)
    {
        writer.WriteValue(string.Join(",", value));
    }

    public override int[] ReadJson(JsonReader reader, Type objectType, int[] existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        List<int> result = new List<int>();

        string jsonString = (string)reader.Value;
        string[] jsonStringParts = jsonString.Split(',');

        foreach (string part in jsonStringParts)
        {
            if(int.TryParse(part, out int partInt)) {
                result.Add(partInt);
            }
        }

        return result.ToArray();
    }

}