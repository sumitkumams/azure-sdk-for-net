// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ContainerServiceClusterSupportEndedEventDataConverter))]
    public partial class ContainerServiceClusterSupportEndedEventData
    {
        internal static ContainerServiceClusterSupportEndedEventData DeserializeContainerServiceClusterSupportEndedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kubernetesVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kubernetesVersion"u8))
                {
                    kubernetesVersion = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerServiceClusterSupportEndedEventData(kubernetesVersion);
        }

        internal partial class ContainerServiceClusterSupportEndedEventDataConverter : JsonConverter<ContainerServiceClusterSupportEndedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ContainerServiceClusterSupportEndedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ContainerServiceClusterSupportEndedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeContainerServiceClusterSupportEndedEventData(document.RootElement);
            }
        }
    }
}
