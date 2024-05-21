// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.OpenAI
{
    internal partial class InternalAzureContentFilterResultForPrompt : IJsonModel<InternalAzureContentFilterResultForPrompt>
    {
        void IJsonModel<InternalAzureContentFilterResultForPrompt>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAzureContentFilterResultForPrompt>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalAzureContentFilterResultForPrompt)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PromptIndex))
            {
                writer.WritePropertyName("prompt_index"u8);
                writer.WriteNumberValue(PromptIndex.Value);
            }
            if (Optional.IsDefined(ContentFilterResults))
            {
                writer.WritePropertyName("content_filter_results"u8);
                writer.WriteObjectValue(ContentFilterResults, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        InternalAzureContentFilterResultForPrompt IJsonModel<InternalAzureContentFilterResultForPrompt>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAzureContentFilterResultForPrompt>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalAzureContentFilterResultForPrompt)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalAzureContentFilterResultForPrompt(document.RootElement, options);
        }

        internal static InternalAzureContentFilterResultForPrompt DeserializeInternalAzureContentFilterResultForPrompt(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? promptIndex = default;
            InternalAzureContentFilterResultForPromptContentFilterResults contentFilterResults = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prompt_index"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    promptIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("content_filter_results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentFilterResults = InternalAzureContentFilterResultForPromptContentFilterResults.DeserializeInternalAzureContentFilterResultForPromptContentFilterResults(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalAzureContentFilterResultForPrompt(promptIndex, contentFilterResults, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalAzureContentFilterResultForPrompt>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAzureContentFilterResultForPrompt>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalAzureContentFilterResultForPrompt)} does not support writing '{options.Format}' format.");
            }
        }

        InternalAzureContentFilterResultForPrompt IPersistableModel<InternalAzureContentFilterResultForPrompt>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAzureContentFilterResultForPrompt>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalAzureContentFilterResultForPrompt(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalAzureContentFilterResultForPrompt)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalAzureContentFilterResultForPrompt>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static InternalAzureContentFilterResultForPrompt FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalAzureContentFilterResultForPrompt(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}