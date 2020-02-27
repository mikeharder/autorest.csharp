// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using AnotherCustomNamespace;
using Azure.Core;
using TypeSchemaMapping.Models;

namespace CustomNamespace
{
    internal partial class CustomizedModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (CustomizedStringProperty != null)
            {
                writer.WritePropertyName("ModelProperty");
                writer.WriteStringValue(CustomizedStringProperty);
            }
            writer.WritePropertyName("Fruit");
            writer.WriteStringValue(CustomizedFancyField.ToString());
            writer.WritePropertyName("DaysOfWeek");
            writer.WriteStringValue(DaysOfWeek.ToString());
            writer.WriteEndObject();
        }
        internal static CustomizedModel DeserializeCustomizedModel(JsonElement element)
        {
            CustomizedModel result = new CustomizedModel();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ModelProperty"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.CustomizedStringProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Fruit"))
                {
                    result.CustomizedFancyField = new CustomFruitEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("DaysOfWeek"))
                {
                    result.DaysOfWeek = new DaysOfWeek(property.Value.GetString());
                    continue;
                }
            }
            return result;
        }
    }
}
