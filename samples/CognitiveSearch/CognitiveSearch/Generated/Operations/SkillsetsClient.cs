// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using CognitiveSearch.Models;

namespace CognitiveSearch
{
    public partial class SkillsetsClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal SkillsetsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of SkillsetsClient for mocking. </summary>
        protected SkillsetsClient()
        {
        }
        /// <summary> Initializes a new instance of SkillsetsClient. </summary>
        internal SkillsetsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2019-05-06-Preview")
        {
            RestClient = new SkillsetsRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Creates a new skillset in a search service or updates the skillset if it already exists. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create or update in a search service. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="accessCondition"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Skillset>> CreateOrUpdateAsync(string skillsetName, Skillset skillset, RequestOptions requestOptions = null, AccessCondition accessCondition = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateOrUpdateAsync(skillsetName, skillset, requestOptions, accessCondition, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new skillset in a search service or updates the skillset if it already exists. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create or update in a search service. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="accessCondition"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Skillset> CreateOrUpdate(string skillsetName, Skillset skillset, RequestOptions requestOptions = null, AccessCondition accessCondition = null, CancellationToken cancellationToken = default)
        {
            return RestClient.CreateOrUpdate(skillsetName, skillset, requestOptions, accessCondition, cancellationToken);
        }

        /// <summary> Deletes a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to delete. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="accessCondition"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string skillsetName, RequestOptions requestOptions = null, AccessCondition accessCondition = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.DeleteAsync(skillsetName, requestOptions, accessCondition, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Deletes a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to delete. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="accessCondition"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string skillsetName, RequestOptions requestOptions = null, AccessCondition accessCondition = null, CancellationToken cancellationToken = default)
        {
            return RestClient.Delete(skillsetName, requestOptions, accessCondition, cancellationToken);
        }

        /// <summary> Retrieves a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to retrieve. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Skillset>> GetAsync(string skillsetName, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(skillsetName, requestOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to retrieve. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Skillset> Get(string skillsetName, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(skillsetName, requestOptions, cancellationToken);
        }

        /// <summary> List all skillsets in a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the skillsets to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ListSkillsetsResult>> ListAsync(string select = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.ListAsync(select, requestOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> List all skillsets in a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the skillsets to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ListSkillsetsResult> List(string select = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return RestClient.List(select, requestOptions, cancellationToken);
        }

        /// <summary> Creates a new skillset in a search service. </summary>
        /// <param name="skillset"> The skillset containing one or more skills to create in a search service. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Skillset>> CreateAsync(Skillset skillset, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateAsync(skillset, requestOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new skillset in a search service. </summary>
        /// <param name="skillset"> The skillset containing one or more skills to create in a search service. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Skillset> Create(Skillset skillset, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return RestClient.Create(skillset, requestOptions, cancellationToken);
        }
    }
}
