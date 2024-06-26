// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> All nodes means the service will be running on all of the nodes of the job. </summary>
    public partial class JobAllNodes : JobNodes
    {
        /// <summary> Initializes a new instance of <see cref="JobAllNodes"/>. </summary>
        public JobAllNodes()
        {
            NodesValueType = NodesValueType.All;
        }

        /// <summary> Initializes a new instance of <see cref="JobAllNodes"/>. </summary>
        /// <param name="nodesValueType"> [Required] Type of the Nodes value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JobAllNodes(NodesValueType nodesValueType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(nodesValueType, serializedAdditionalRawData)
        {
            NodesValueType = nodesValueType;
        }
    }
}
