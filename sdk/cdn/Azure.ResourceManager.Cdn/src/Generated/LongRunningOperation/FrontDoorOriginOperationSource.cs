// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Cdn
{
    internal class FrontDoorOriginOperationSource : IOperationSource<FrontDoorOriginResource>
    {
        private readonly ArmClient _client;

        internal FrontDoorOriginOperationSource(ArmClient client)
        {
            _client = client;
        }

        FrontDoorOriginResource IOperationSource<FrontDoorOriginResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = FrontDoorOriginData.DeserializeFrontDoorOriginData(document.RootElement);
            return new FrontDoorOriginResource(_client, data);
        }

        async ValueTask<FrontDoorOriginResource> IOperationSource<FrontDoorOriginResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = FrontDoorOriginData.DeserializeFrontDoorOriginData(document.RootElement);
            return new FrontDoorOriginResource(_client, data);
        }
    }
}
