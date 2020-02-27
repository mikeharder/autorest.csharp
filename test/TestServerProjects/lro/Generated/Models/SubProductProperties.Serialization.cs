// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace lro.Models
{
    public partial class SubProductProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState);
            }
            if (ProvisioningStateValues != null)
            {
                writer.WritePropertyName("provisioningStateValues");
                writer.WriteStringValue(ProvisioningStateValues.Value.ToString());
            }
            writer.WriteEndObject();
        }
        internal static SubProductProperties DeserializeSubProductProperties(JsonElement element)
        {
            SubProductProperties result = new SubProductProperties();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ProvisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStateValues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ProvisioningStateValues = new SubProductPropertiesProvisioningStateValues(property.Value.GetString());
                    continue;
                }
            }
            return result;
        }
    }
}
