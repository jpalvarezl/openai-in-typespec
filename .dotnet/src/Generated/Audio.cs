// <auto-generated/>

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenAI.Internal.Models;

namespace OpenAI.Internal
{
    // Data plane generated sub-client.
    /// <summary> The Audio sub-client. </summary>
    internal partial class Audio
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _credential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Audio for mocking. </summary>
        protected Audio()
        {
        }

        /// <summary> Initializes a new instance of Audio. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="credential"> The key credential to copy. </param>
        /// <param name="endpoint"> OpenAI Endpoint. </param>
        internal Audio(ClientPipeline pipeline, ApiKeyCredential credential, Uri endpoint)
        {
            _pipeline = pipeline;
            _credential = credential;
            _endpoint = endpoint;
        }

        /// <summary> Generates audio from the input text. </summary>
        /// <param name="speech"> The <see cref="CreateSpeechRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="speech"/> is null. </exception>
        public virtual async Task<ClientResult<BinaryData>> CreateSpeechAsync(CreateSpeechRequest speech)
        {
            if (speech is null) throw new ArgumentNullException(nameof(speech));

            using BinaryContent content = BinaryContent.Create(speech);
            ClientResult result = await CreateSpeechAsync(content, DefaultRequestContext).ConfigureAwait(false);
            return ClientResult.FromValue(result.GetRawResponse().Content, result.GetRawResponse());
        }

        /// <summary> Generates audio from the input text. </summary>
        /// <param name="speech"> The <see cref="CreateSpeechRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="speech"/> is null. </exception>
        public virtual ClientResult<BinaryData> CreateSpeech(CreateSpeechRequest speech)
        {
            if (speech is null) throw new ArgumentNullException(nameof(speech));

            using BinaryContent content = BinaryContent.Create(speech);
            ClientResult result = CreateSpeech(content, DefaultRequestContext);
            return ClientResult.FromValue(result.GetRawResponse().Content, result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Generates audio from the input text.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateSpeechAsync(CreateSpeechRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateSpeechAsync(BinaryContent content, RequestOptions options = null)
        {
            if (content is null) throw new ArgumentNullException(nameof(content));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateCreateSpeechRequest(content, options);
            await _pipeline.SendAsync(message).ConfigureAwait(false);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw await ClientResultException.CreateAsync(response).ConfigureAwait(false);
            }

            return ClientResult.FromResponse(response);
        }

        /// <summary>
        /// [Protocol Method] Generates audio from the input text.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateSpeech(CreateSpeechRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult CreateSpeech(BinaryContent content, RequestOptions options = null)
        {
            if (content is null) throw new ArgumentNullException(nameof(content));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateCreateSpeechRequest(content, options);
            _pipeline.Send(message);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw new ClientResultException(response);
            }

            return ClientResult.FromResponse(response);
        }

        /// <summary> Transcribes audio into the input language. </summary>
        /// <param name="audio"> The <see cref="CreateTranscriptionRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="audio"/> is null. </exception>
        public virtual async Task<ClientResult<CreateTranscriptionResponse>> CreateTranscriptionAsync(CreateTranscriptionRequest audio)
        {
            if (audio is null) throw new ArgumentNullException(nameof(audio));

            using BinaryContent content = BinaryContent.Create(audio);
            ClientResult result = await CreateTranscriptionAsync(content, DefaultRequestContext).ConfigureAwait(false);
            return ClientResult.FromValue(CreateTranscriptionResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Transcribes audio into the input language. </summary>
        /// <param name="audio"> The <see cref="CreateTranscriptionRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="audio"/> is null. </exception>
        public virtual ClientResult<CreateTranscriptionResponse> CreateTranscription(CreateTranscriptionRequest audio)
        {
            if (audio is null) throw new ArgumentNullException(nameof(audio));

            using BinaryContent content = BinaryContent.Create(audio);
            ClientResult result = CreateTranscription(content, DefaultRequestContext);
            return ClientResult.FromValue(CreateTranscriptionResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Transcribes audio into the input language.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateTranscriptionAsync(CreateTranscriptionRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateTranscriptionAsync(BinaryContent content, RequestOptions options = null)
        {
            if (content is null) throw new ArgumentNullException(nameof(content));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateCreateTranscriptionRequest(content, options);
            await _pipeline.SendAsync(message).ConfigureAwait(false);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw await ClientResultException.CreateAsync(response).ConfigureAwait(false);
            }

            return ClientResult.FromResponse(response);
        }

        /// <summary>
        /// [Protocol Method] Transcribes audio into the input language.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateTranscription(CreateTranscriptionRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult CreateTranscription(BinaryContent content, RequestOptions options = null)
        {
            if (content is null) throw new ArgumentNullException(nameof(content));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateCreateTranscriptionRequest(content, options);
            _pipeline.Send(message);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw new ClientResultException(response);
            }

            return ClientResult.FromResponse(response);
        }

        /// <summary> Translates audio into English.. </summary>
        /// <param name="audio"> The <see cref="CreateTranslationRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="audio"/> is null. </exception>
        public virtual async Task<ClientResult<CreateTranslationResponse>> CreateTranslationAsync(CreateTranslationRequest audio)
        {
            if (audio is null) throw new ArgumentNullException(nameof(audio));

            using BinaryContent content = BinaryContent.Create(audio);
            ClientResult result = await CreateTranslationAsync(content, DefaultRequestContext).ConfigureAwait(false);
            return ClientResult.FromValue(CreateTranslationResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Translates audio into English.. </summary>
        /// <param name="audio"> The <see cref="CreateTranslationRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="audio"/> is null. </exception>
        public virtual ClientResult<CreateTranslationResponse> CreateTranslation(CreateTranslationRequest audio)
        {
            if (audio is null) throw new ArgumentNullException(nameof(audio));

            using BinaryContent content = BinaryContent.Create(audio);
            ClientResult result = CreateTranslation(content, DefaultRequestContext);
            return ClientResult.FromValue(CreateTranslationResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Translates audio into English..
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateTranslationAsync(CreateTranslationRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateTranslationAsync(BinaryContent content, RequestOptions options = null)
        {
            if (content is null) throw new ArgumentNullException(nameof(content));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateCreateTranslationRequest(content, options);
            await _pipeline.SendAsync(message).ConfigureAwait(false);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw await ClientResultException.CreateAsync(response).ConfigureAwait(false);
            }

            return ClientResult.FromResponse(response);
        }

        /// <summary>
        /// [Protocol Method] Translates audio into English..
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateTranslation(CreateTranslationRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult CreateTranslation(BinaryContent content, RequestOptions options = null)
        {
            if (content is null) throw new ArgumentNullException(nameof(content));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateCreateTranslationRequest(content, options);
            _pipeline.Send(message);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw new ClientResultException(response);
            }

            return ClientResult.FromResponse(response);
        }

        internal PipelineMessage CreateCreateSpeechRequest(BinaryContent content, RequestOptions options)
        {
            PipelineMessage message = _pipeline.CreateMessage();
            message.ResponseClassifier = ResponseErrorClassifier200;
            PipelineRequest request = message.Request;
            request.Method = "POST";
            UriBuilder uriBuilder = new(_endpoint.ToString());
            StringBuilder path = new();
            path.Append("/audio/speech");
            uriBuilder.Path += path.ToString();
            request.Uri = uriBuilder.Uri;
            request.Headers.Set("Accept", "application/octet-stream");
            request.Headers.Set("Content-Type", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateCreateTranscriptionRequest(BinaryContent content, RequestOptions options)
        {
            PipelineMessage message = _pipeline.CreateMessage();
            message.ResponseClassifier = ResponseErrorClassifier200;
            PipelineRequest request = message.Request;
            request.Method = "POST";
            UriBuilder uriBuilder = new(_endpoint.ToString());
            StringBuilder path = new();
            path.Append("/audio/transcriptions");
            uriBuilder.Path += path.ToString();
            request.Uri = uriBuilder.Uri;
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("content-type", "multipart/form-data");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateCreateTranslationRequest(BinaryContent content, RequestOptions options)
        {
            PipelineMessage message = _pipeline.CreateMessage();
            message.ResponseClassifier = ResponseErrorClassifier200;
            PipelineRequest request = message.Request;
            request.Method = "POST";
            UriBuilder uriBuilder = new(_endpoint.ToString());
            StringBuilder path = new();
            path.Append("/audio/translations");
            uriBuilder.Path += path.ToString();
            request.Uri = uriBuilder.Uri;
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("content-type", "multipart/form-data");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        private static RequestOptions DefaultRequestContext = new RequestOptions();

        private static PipelineMessageClassifier _responseErrorClassifier200;
        private static PipelineMessageClassifier ResponseErrorClassifier200 => _responseErrorClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
    }
}