// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DatabaseFleetManager.Models
{
    internal partial class FleetUpdateRunStrategy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("stages"u8);
            writer.WriteStartArray();
            foreach (var item in Stages)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static FleetUpdateRunStrategy DeserializeFleetUpdateRunStrategy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<FleetUpdateStage> stages = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stages"u8))
                {
                    List<FleetUpdateStage> array = new List<FleetUpdateStage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FleetUpdateStage.DeserializeFleetUpdateStage(item));
                    }
                    stages = array;
                    continue;
                }
            }
            return new FleetUpdateRunStrategy(stages);
        }
    }
}
