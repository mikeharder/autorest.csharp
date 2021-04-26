// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.Management.Storage.Models;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A Class representing a ManagementPolicy along with the instance operations that can be performed on it. </summary>
    public class ManagementPolicy : ManagementPolicyOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "ManagementPolicy"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ManagementPolicy(ResourceOperationsBase options, ManagementPolicyData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ManagementPolicyData. </summary>
        public ManagementPolicyData Data { get; private set; }

        /// <inheritdoc />
        protected override ManagementPolicy GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<ManagementPolicy> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
