// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Chat
{
    /// <summary> The AzureMachineLearningIndexChatDataSourceParameters. </summary>
    internal partial class InternalAzureMachineLearningIndexChatDataSourceParameters
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InternalAzureMachineLearningIndexChatDataSourceParameters"/>. </summary>
        /// <param name="authentication">
        /// Please note <see cref="DataSourceAuthentication"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes..
        /// </param>
        /// <param name="projectResourceId"> The ID of the Azure Machine Learning index project to use. </param>
        /// <param name="name"> The name of the Azure Machine Learning index to use. </param>
        /// <param name="version"> The version of the vector index to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authentication"/>, <paramref name="projectResourceId"/>, <paramref name="name"/> or <paramref name="version"/> is null. </exception>
        internal InternalAzureMachineLearningIndexChatDataSourceParameters(DataSourceAuthentication authentication, string projectResourceId, string name, string version)
        {
            Argument.AssertNotNull(authentication, nameof(authentication));
            Argument.AssertNotNull(projectResourceId, nameof(projectResourceId));
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(version, nameof(version));

            _internalIncludeContexts = new ChangeTrackingList<string>();
            Authentication = authentication;
            ProjectResourceId = projectResourceId;
            Name = name;
            Version = version;
        }

        /// <summary> Initializes a new instance of <see cref="InternalAzureMachineLearningIndexChatDataSourceParameters"/>. </summary>
        /// <param name="topNDocuments"> The configured number of documents to feature in the query. </param>
        /// <param name="inScope"> Whether queries should be restricted to use of the indexed data. </param>
        /// <param name="strictness">
        /// The configured strictness of the search relevance filtering.
        /// Higher strictness will increase precision but lower recall of the answer.
        /// </param>
        /// <param name="roleInformation">
        /// Additional instructions for the model to inform how it should behave and any context it should reference when
        /// generating a response. You can describe the assistant's personality and tell it how to format responses.
        /// This is limited to 100 tokens and counts against the overall token limit.
        /// </param>
        /// <param name="maxSearchQueries">
        /// The maximum number of rewritten queries that should be sent to the search provider for a single user message.
        /// By default, the system will make an automatic determination.
        /// </param>
        /// <param name="allowPartialResult">
        /// If set to true, the system will allow partial search results to be used and the request will fail if all
        /// partial queries fail. If not specified or specified as false, the request will fail if any search query fails.
        /// </param>
        /// <param name="internalIncludeContexts">
        /// The output context properties to include on the response.
        /// By default, citations and intent will be requested.
        /// </param>
        /// <param name="authentication">
        /// Please note <see cref="DataSourceAuthentication"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes..
        /// </param>
        /// <param name="projectResourceId"> The ID of the Azure Machine Learning index project to use. </param>
        /// <param name="name"> The name of the Azure Machine Learning index to use. </param>
        /// <param name="version"> The version of the vector index to use. </param>
        /// <param name="filter"> A search filter, which is only applicable if the vector index is of the 'AzureSearch' type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalAzureMachineLearningIndexChatDataSourceParameters(int? topNDocuments, bool? inScope, int? strictness, string roleInformation, int? maxSearchQueries, bool? allowPartialResult, IList<string> internalIncludeContexts, DataSourceAuthentication authentication, string projectResourceId, string name, string version, string filter, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TopNDocuments = topNDocuments;
            InScope = inScope;
            Strictness = strictness;
            RoleInformation = roleInformation;
            MaxSearchQueries = maxSearchQueries;
            AllowPartialResult = allowPartialResult;
            _internalIncludeContexts = internalIncludeContexts;
            Authentication = authentication;
            ProjectResourceId = projectResourceId;
            Name = name;
            Version = version;
            Filter = filter;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalAzureMachineLearningIndexChatDataSourceParameters"/> for deserialization. </summary>
        internal InternalAzureMachineLearningIndexChatDataSourceParameters()
        {
        }

        /// <summary> The configured number of documents to feature in the query. </summary>
        internal int? TopNDocuments { get; set; }
        /// <summary> Whether queries should be restricted to use of the indexed data. </summary>
        internal bool? InScope { get; set; }
        /// <summary>
        /// The configured strictness of the search relevance filtering.
        /// Higher strictness will increase precision but lower recall of the answer.
        /// </summary>
        internal int? Strictness { get; set; }
        /// <summary>
        /// Additional instructions for the model to inform how it should behave and any context it should reference when
        /// generating a response. You can describe the assistant's personality and tell it how to format responses.
        /// This is limited to 100 tokens and counts against the overall token limit.
        /// </summary>
        internal string RoleInformation { get; set; }
        /// <summary>
        /// The maximum number of rewritten queries that should be sent to the search provider for a single user message.
        /// By default, the system will make an automatic determination.
        /// </summary>
        internal int? MaxSearchQueries { get; set; }
        /// <summary>
        /// If set to true, the system will allow partial search results to be used and the request will fail if all
        /// partial queries fail. If not specified or specified as false, the request will fail if any search query fails.
        /// </summary>
        internal bool? AllowPartialResult { get; set; }
        /// <summary> The ID of the Azure Machine Learning index project to use. </summary>
        internal string ProjectResourceId { get; set; }
        /// <summary> The name of the Azure Machine Learning index to use. </summary>
        internal string Name { get; set; }
        /// <summary> The version of the vector index to use. </summary>
        internal string Version { get; set; }
        /// <summary> A search filter, which is only applicable if the vector index is of the 'AzureSearch' type. </summary>
        internal string Filter { get; set; }
    }
}
