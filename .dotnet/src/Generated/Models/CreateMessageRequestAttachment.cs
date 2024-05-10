// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Internal.Models
{
    /// <summary> The CreateMessageRequestAttachment. </summary>
    internal partial class CreateMessageRequestAttachment
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

        /// <summary> Initializes a new instance of <see cref="CreateMessageRequestAttachment"/>. </summary>
        /// <param name="fileId"> The ID of the file to attach to the message. </param>
        /// <param name="tools"> The tools to add this file to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> or <paramref name="tools"/> is null. </exception>
        public CreateMessageRequestAttachment(string fileId, IEnumerable<BinaryData> tools)
        {
            Argument.AssertNotNull(fileId, nameof(fileId));
            Argument.AssertNotNull(tools, nameof(tools));

            FileId = fileId;
            Tools = tools.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CreateMessageRequestAttachment"/>. </summary>
        /// <param name="fileId"> The ID of the file to attach to the message. </param>
        /// <param name="tools"> The tools to add this file to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateMessageRequestAttachment(string fileId, IList<BinaryData> tools, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileId = fileId;
            Tools = tools;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateMessageRequestAttachment"/> for deserialization. </summary>
        internal CreateMessageRequestAttachment()
        {
        }

        /// <summary> The ID of the file to attach to the message. </summary>
        public string FileId { get; }
        /// <summary>
        /// The tools to add this file to.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="AssistantToolsCode"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="AssistantToolsFileSearch"/></description>
        /// </item>
        /// </list>
        /// </remarks>
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
        public IList<BinaryData> Tools { get; }
    }
}