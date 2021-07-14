// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace SupersetFlattenInheritance
{
    public partial class WritableSubResourceModel2SPutOperation : Operation<WritableSubResourceModel2>
    {
        private readonly OperationOrResponseInternals<WritableSubResourceModel2> _operation;

        /// <summary> Initializes a new instance of WritableSubResourceModel2SPutOperation for mocking. </summary>
        protected WritableSubResourceModel2SPutOperation()
        {
        }

        internal WritableSubResourceModel2SPutOperation(OperationsBase operationsBase, Response<WritableSubResourceModel2Data> response)
        {
            _operation = new OperationOrResponseInternals<WritableSubResourceModel2>(Response.FromValue(new WritableSubResourceModel2(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override WritableSubResourceModel2 Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<WritableSubResourceModel2>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<WritableSubResourceModel2>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
