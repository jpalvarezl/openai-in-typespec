// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> A content filter result associated with a single input prompt item into a generative AI system. </summary>
    public partial class ContentFilterResultForPrompt
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

        /// <summary> Initializes a new instance of <see cref="ContentFilterResultForPrompt"/>. </summary>
        internal ContentFilterResultForPrompt()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContentFilterResultForPrompt"/>. </summary>
        /// <param name="promptIndex"> The index of the input prompt associated with the accompanying content filter result categories. </param>
        /// <param name="internalResults"> The content filter category details for the result. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContentFilterResultForPrompt(int? promptIndex, InternalAzureContentFilterResultForPromptContentFilterResults internalResults, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PromptIndex = promptIndex;
            InternalResults = internalResults;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}