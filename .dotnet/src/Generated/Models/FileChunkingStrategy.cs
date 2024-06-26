// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.VectorStores
{
    public abstract partial class FileChunkingStrategy
    {
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        protected FileChunkingStrategy()
        {
        }

        internal FileChunkingStrategy(string type, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal string Type { get; init; }
    }
}
