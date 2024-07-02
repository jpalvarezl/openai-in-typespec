// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> The AzureContentFilterResultForPromptContentFilterResults. </summary>
    internal partial class InternalAzureContentFilterResultForPromptContentFilterResults
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

        /// <summary> Initializes a new instance of <see cref="InternalAzureContentFilterResultForPromptContentFilterResults"/>. </summary>
        /// <param name="jailbreak">
        /// A detection result that describes user prompt injection attacks, where malicious users deliberately exploit
        /// system vulnerabilities to elicit unauthorized behavior from the LLM. This could lead to inappropriate content
        /// generation or violations of system-imposed restrictions.
        /// </param>
        /// <param name="indirectAttack">
        /// A detection result that describes attacks on systems powered by Generative AI models that can happen every time
        /// an application processes information that wasn’t directly authored by either the developer of the application or
        /// the user.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jailbreak"/> or <paramref name="indirectAttack"/> is null. </exception>
        internal InternalAzureContentFilterResultForPromptContentFilterResults(ContentFilterDetectionResult jailbreak, ContentFilterDetectionResult indirectAttack)
        {
            Argument.AssertNotNull(jailbreak, nameof(jailbreak));
            Argument.AssertNotNull(indirectAttack, nameof(indirectAttack));

            Jailbreak = jailbreak;
            IndirectAttack = indirectAttack;
        }

        /// <summary> Initializes a new instance of <see cref="InternalAzureContentFilterResultForPromptContentFilterResults"/>. </summary>
        /// <param name="sexual">
        /// A content filter category for language related to anatomical organs and genitals, romantic relationships, acts
        /// portrayed in erotic or affectionate terms, pregnancy, physical sexual acts, including those portrayed as an
        /// assault or a forced sexual violent act against one's will, prostitution, pornography, and abuse.
        /// </param>
        /// <param name="hate">
        /// A content filter category that can refer to any content that attacks or uses pejorative or discriminatory
        /// language with reference to a person or identity group based on certain differentiating attributes of these groups
        /// including but not limited to race, ethnicity, nationality, gender identity and expression, sexual orientation,
        /// religion, immigration status, ability status, personal appearance, and body size.
        /// </param>
        /// <param name="violence">
        /// A content filter category for language related to physical actions intended to hurt, injure, damage, or kill
        /// someone or something; describes weapons, guns and related entities, such as manufactures, associations,
        /// legislation, and so on.
        /// </param>
        /// <param name="selfHarm">
        /// A content filter category that describes language related to physical actions intended to purposely hurt, injure,
        /// damage one's body or kill oneself.
        /// </param>
        /// <param name="profanity">
        /// A detection result that identifies whether crude, vulgar, or otherwise objection language is present in the
        /// content.
        /// </param>
        /// <param name="customBlocklists"> A collection of binary filtering outcomes for configured custom blocklists. </param>
        /// <param name="error"> If present, details about an error that prevented content filtering from completing its evaluation. </param>
        /// <param name="jailbreak">
        /// A detection result that describes user prompt injection attacks, where malicious users deliberately exploit
        /// system vulnerabilities to elicit unauthorized behavior from the LLM. This could lead to inappropriate content
        /// generation or violations of system-imposed restrictions.
        /// </param>
        /// <param name="indirectAttack">
        /// A detection result that describes attacks on systems powered by Generative AI models that can happen every time
        /// an application processes information that wasn’t directly authored by either the developer of the application or
        /// the user.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalAzureContentFilterResultForPromptContentFilterResults(ContentFilterSeverityResult sexual, ContentFilterSeverityResult hate, ContentFilterSeverityResult violence, ContentFilterSeverityResult selfHarm, ContentFilterDetectionResult profanity, ContentFilterBlocklistResult customBlocklists, InternalAzureContentFilterResultForPromptContentFilterResultsError error, ContentFilterDetectionResult jailbreak, ContentFilterDetectionResult indirectAttack, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sexual = sexual;
            Hate = hate;
            Violence = violence;
            SelfHarm = selfHarm;
            Profanity = profanity;
            CustomBlocklists = customBlocklists;
            Error = error;
            Jailbreak = jailbreak;
            IndirectAttack = indirectAttack;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalAzureContentFilterResultForPromptContentFilterResults"/> for deserialization. </summary>
        internal InternalAzureContentFilterResultForPromptContentFilterResults()
        {
        }

        /// <summary>
        /// A content filter category for language related to anatomical organs and genitals, romantic relationships, acts
        /// portrayed in erotic or affectionate terms, pregnancy, physical sexual acts, including those portrayed as an
        /// assault or a forced sexual violent act against one's will, prostitution, pornography, and abuse.
        /// </summary>
        internal ContentFilterSeverityResult Sexual { get; set; }
        /// <summary>
        /// A content filter category that can refer to any content that attacks or uses pejorative or discriminatory
        /// language with reference to a person or identity group based on certain differentiating attributes of these groups
        /// including but not limited to race, ethnicity, nationality, gender identity and expression, sexual orientation,
        /// religion, immigration status, ability status, personal appearance, and body size.
        /// </summary>
        internal ContentFilterSeverityResult Hate { get; set; }
        /// <summary>
        /// A content filter category for language related to physical actions intended to hurt, injure, damage, or kill
        /// someone or something; describes weapons, guns and related entities, such as manufactures, associations,
        /// legislation, and so on.
        /// </summary>
        internal ContentFilterSeverityResult Violence { get; set; }
        /// <summary>
        /// A content filter category that describes language related to physical actions intended to purposely hurt, injure,
        /// damage one's body or kill oneself.
        /// </summary>
        internal ContentFilterSeverityResult SelfHarm { get; set; }
        /// <summary>
        /// A detection result that identifies whether crude, vulgar, or otherwise objection language is present in the
        /// content.
        /// </summary>
        internal ContentFilterDetectionResult Profanity { get; set; }
        /// <summary> A collection of binary filtering outcomes for configured custom blocklists. </summary>
        internal ContentFilterBlocklistResult CustomBlocklists { get; set; }
        /// <summary> If present, details about an error that prevented content filtering from completing its evaluation. </summary>
        internal InternalAzureContentFilterResultForPromptContentFilterResultsError Error { get; set; }
        /// <summary>
        /// A detection result that describes user prompt injection attacks, where malicious users deliberately exploit
        /// system vulnerabilities to elicit unauthorized behavior from the LLM. This could lead to inappropriate content
        /// generation or violations of system-imposed restrictions.
        /// </summary>
        internal ContentFilterDetectionResult Jailbreak { get; set; }
        /// <summary>
        /// A detection result that describes attacks on systems powered by Generative AI models that can happen every time
        /// an application processes information that wasn’t directly authored by either the developer of the application or
        /// the user.
        /// </summary>
        internal ContentFilterDetectionResult IndirectAttack { get; set; }
    }
}
