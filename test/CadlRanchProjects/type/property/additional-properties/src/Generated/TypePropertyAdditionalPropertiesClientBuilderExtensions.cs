// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using _Type.Property.AdditionalProperties;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="AdditionalPropertiesClient"/> to client builder. </summary>
    public static partial class TypePropertyAdditionalPropertiesClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="AdditionalPropertiesClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> TestServer endpoint. </param>
        public static IAzureClientBuilder<AdditionalPropertiesClient, AdditionalPropertiesClientOptions> AddAdditionalPropertiesClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<AdditionalPropertiesClient, AdditionalPropertiesClientOptions>((options) => new AdditionalPropertiesClient(endpoint, options));
        }

        /// <summary> Registers a <see cref="AdditionalPropertiesClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<AdditionalPropertiesClient, AdditionalPropertiesClientOptions> AddAdditionalPropertiesClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<AdditionalPropertiesClient, AdditionalPropertiesClientOptions>(configuration);
        }
    }
}
