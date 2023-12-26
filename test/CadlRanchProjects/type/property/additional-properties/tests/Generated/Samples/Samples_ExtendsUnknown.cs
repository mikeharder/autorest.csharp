// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using _Type.Property.AdditionalProperties;
using _Type.Property.AdditionalProperties.Models;

namespace _Type.Property.AdditionalProperties.Samples
{
    public partial class Samples_ExtendsUnknown
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknown_GetExtendsUnknown_ShortVersion()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            Response response = client.GetExtendsUnknown(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknown_GetExtendsUnknown_ShortVersion_Async()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            Response response = await client.GetExtendsUnknownAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknown_GetExtendsUnknown_ShortVersion_Convenience()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            Response<ExtendsUnknownAdditionalProperties> response = client.GetExtendsUnknown();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknown_GetExtendsUnknown_ShortVersion_Convenience_Async()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            Response<ExtendsUnknownAdditionalProperties> response = await client.GetExtendsUnknownAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknown_GetExtendsUnknown_AllParameters()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            Response response = client.GetExtendsUnknown(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknown_GetExtendsUnknown_AllParameters_Async()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            Response response = await client.GetExtendsUnknownAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknown_GetExtendsUnknown_AllParameters_Convenience()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            Response<ExtendsUnknownAdditionalProperties> response = client.GetExtendsUnknown();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknown_GetExtendsUnknown_AllParameters_Convenience_Async()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            Response<ExtendsUnknownAdditionalProperties> response = await client.GetExtendsUnknownAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknown_Put_ShortVersion()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknown_Put_ShortVersion_Async()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknown_Put_ShortVersion_Convenience()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            ExtendsUnknownAdditionalProperties body = new ExtendsUnknownAdditionalProperties("<name>");
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknown_Put_ShortVersion_Convenience_Async()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            ExtendsUnknownAdditionalProperties body = new ExtendsUnknownAdditionalProperties("<name>");
            Response response = await client.PutAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknown_Put_AllParameters()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknown_Put_AllParameters_Async()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknown_Put_AllParameters_Convenience()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            ExtendsUnknownAdditionalProperties body = new ExtendsUnknownAdditionalProperties("<name>");
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknown_Put_AllParameters_Convenience_Async()
        {
            ExtendsUnknown client = new AdditionalPropertiesClient().GetExtendsUnknownClient(apiVersion: "1.0.0");

            ExtendsUnknownAdditionalProperties body = new ExtendsUnknownAdditionalProperties("<name>");
            Response response = await client.PutAsync(body);
        }
    }
}
