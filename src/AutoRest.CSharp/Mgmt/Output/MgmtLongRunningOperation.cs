// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using AutoRest.CSharp.Common.Output.Models;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Decorator;
using AutoRest.CSharp.Output.Builders;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Utilities;

namespace AutoRest.CSharp.Mgmt.Output
{
    /// <summary>
    /// Represents a management plane long-running-operation.
    /// </summary>
    internal class MgmtLongRunningOperation : LongRunningOperation
    {
        public MgmtLongRunningOperation(OperationGroup operationGroup, Input.Operation operation, BuildContext<MgmtOutputLibrary> context, LongRunningOperationInfo lroInfo)
            : base(operation, context, lroInfo, lroInfo.ClientPrefix.ToSingular() + operation.CSharpName() + "Operation")
        {
            DefaultNamespace = $"{context.DefaultNamespace}.Models";
            if (LongRunningOperationHelper.ShouldWrapResultType(context, operationGroup, operation, ResultType))
            {
                WrapperType = context.Library.GetArmResource(operationGroup).Type;
            }
        }

        /// <summary>
        /// Type of the [Resource] class to replace whatever response type in the LRO.
        /// Only valid for PUT operations.
        /// </summary>
        /// <value></value>
        public CSharpType? WrapperType { get; }

        protected override string DefaultNamespace { get; }
    }
}
