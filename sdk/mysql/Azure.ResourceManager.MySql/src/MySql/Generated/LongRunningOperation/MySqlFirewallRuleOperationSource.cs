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

namespace Azure.ResourceManager.MySql
{
    internal class MySqlFirewallRuleOperationSource : IOperationSource<MySqlFirewallRuleResource>
    {
        private readonly ArmClient _client;

        internal MySqlFirewallRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        MySqlFirewallRuleResource IOperationSource<MySqlFirewallRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MySqlFirewallRuleData.DeserializeMySqlFirewallRuleData(document.RootElement);
            return new MySqlFirewallRuleResource(_client, data);
        }

        async ValueTask<MySqlFirewallRuleResource> IOperationSource<MySqlFirewallRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MySqlFirewallRuleData.DeserializeMySqlFirewallRuleData(document.RootElement);
            return new MySqlFirewallRuleResource(_client, data);
        }
    }
}
