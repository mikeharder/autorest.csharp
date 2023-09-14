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
using _Type.Property.Optionality;
using _Type.Property.Optionality.Models;

namespace _Type.Property.Optionality.Samples
{
    internal class Samples_Bytes
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAll()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response response = client.GetAll(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAll_AllParameters()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response response = client.GetAll(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAll_Convenience()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response<BytesProperty> response = client.GetAll();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAll_AllParameters_Convenience()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response<BytesProperty> response = client.GetAll();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAll_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response response = await client.GetAllAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAll_AllParameters_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response response = await client.GetAllAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAll_Convenience_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response<BytesProperty> response = await client.GetAllAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAll_AllParameters_Convenience_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response<BytesProperty> response = await client.GetAllAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDefault()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response response = client.GetDefault(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDefault_AllParameters()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response response = client.GetDefault(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDefault_Convenience()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response<BytesProperty> response = client.GetDefault();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDefault_AllParameters_Convenience()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response<BytesProperty> response = client.GetDefault();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDefault_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response response = await client.GetDefaultAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDefault_AllParameters_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response response = await client.GetDefaultAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDefault_Convenience_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response<BytesProperty> response = await client.GetDefaultAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDefault_AllParameters_Convenience_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            Response<BytesProperty> response = await client.GetDefaultAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutAll()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new object());
            Response response = client.PutAll(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutAll_AllParameters()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = new object(),
            });
            Response response = client.PutAll(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutAll_Convenience()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            BytesProperty body = new BytesProperty();
            Response response = client.PutAll(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutAll_AllParameters_Convenience()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            BytesProperty body = new BytesProperty()
            {
                Property = BinaryData.FromObjectAsJson(new object()),
            };
            Response response = client.PutAll(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutAll_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.PutAllAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutAll_AllParameters_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = new object(),
            });
            Response response = await client.PutAllAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutAll_Convenience_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            BytesProperty body = new BytesProperty();
            Response response = await client.PutAllAsync(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutAll_AllParameters_Convenience_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            BytesProperty body = new BytesProperty()
            {
                Property = BinaryData.FromObjectAsJson(new object()),
            };
            Response response = await client.PutAllAsync(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutDefault()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new object());
            Response response = client.PutDefault(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutDefault_AllParameters()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = new object(),
            });
            Response response = client.PutDefault(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutDefault_Convenience()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            BytesProperty body = new BytesProperty();
            Response response = client.PutDefault(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutDefault_AllParameters_Convenience()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            BytesProperty body = new BytesProperty()
            {
                Property = BinaryData.FromObjectAsJson(new object()),
            };
            Response response = client.PutDefault(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutDefault_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.PutDefaultAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutDefault_AllParameters_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            RequestContent content = RequestContent.Create(new
            {
                property = new object(),
            });
            Response response = await client.PutDefaultAsync(content);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutDefault_Convenience_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            BytesProperty body = new BytesProperty();
            Response response = await client.PutDefaultAsync(body);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutDefault_AllParameters_Convenience_Async()
        {
            Bytes client = new OptionalClient().GetBytesClient(apiVersion: "1.0.0");

            BytesProperty body = new BytesProperty()
            {
                Property = BinaryData.FromObjectAsJson(new object()),
            };
            Response response = await client.PutDefaultAsync(body);
            Console.WriteLine(response.Status);
        }
    }
}
