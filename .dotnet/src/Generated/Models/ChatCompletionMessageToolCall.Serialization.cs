// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Internal.Models
{
    internal partial class ChatCompletionMessageToolCall : IJsonModel<ChatCompletionMessageToolCall>
    {
        void IJsonModel<ChatCompletionMessageToolCall>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionMessageToolCall>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionMessageToolCall)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("function"u8);
            writer.WriteObjectValue(Function);
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

        ChatCompletionMessageToolCall IJsonModel<ChatCompletionMessageToolCall>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionMessageToolCall>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionMessageToolCall)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatCompletionMessageToolCall(document.RootElement, options);
        }

        internal static ChatCompletionMessageToolCall DeserializeChatCompletionMessageToolCall(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            ChatCompletionMessageToolCallType type = default;
            ChatCompletionMessageToolCallFunction function = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ChatCompletionMessageToolCallType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("function"u8))
                {
                    function = ChatCompletionMessageToolCallFunction.DeserializeChatCompletionMessageToolCallFunction(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ChatCompletionMessageToolCall(id, type, function, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChatCompletionMessageToolCall>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionMessageToolCall>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionMessageToolCall)} does not support '{options.Format}' format.");
            }
        }

        ChatCompletionMessageToolCall IPersistableModel<ChatCompletionMessageToolCall>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionMessageToolCall>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChatCompletionMessageToolCall(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionMessageToolCall)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatCompletionMessageToolCall>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ChatCompletionMessageToolCall FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatCompletionMessageToolCall(document.RootElement);
        }
    }
}