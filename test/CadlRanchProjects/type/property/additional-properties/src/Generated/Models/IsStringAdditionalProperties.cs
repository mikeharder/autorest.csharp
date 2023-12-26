// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace _Type.Property.AdditionalProperties.Models
{
    /// <summary> The model is from Record&lt;string&gt; type. </summary>
    public partial class IsStringAdditionalProperties
    {
        /// <summary> Initializes a new instance of <see cref="IsStringAdditionalProperties"/>. </summary>
        /// <param name="name"> The name property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public IsStringAdditionalProperties(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            AdditionalProperties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="IsStringAdditionalProperties"/>. </summary>
        /// <param name="name"> The name property. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal IsStringAdditionalProperties(string name, IDictionary<string, string> additionalProperties)
        {
            Name = name;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The name property. </summary>
        public string Name { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, string> AdditionalProperties { get; }
    }
}
