// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The CreateTranscriptionResponse_task. </summary>
    internal readonly partial struct CreateTranscriptionResponseTask : IEquatable<CreateTranscriptionResponseTask>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreateTranscriptionResponseTask"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateTranscriptionResponseTask(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TranscribeValue = "transcribe";

        /// <summary> transcribe. </summary>
        public static CreateTranscriptionResponseTask Transcribe { get; } = new CreateTranscriptionResponseTask(TranscribeValue);
        /// <summary> Determines if two <see cref="CreateTranscriptionResponseTask"/> values are the same. </summary>
        public static bool operator ==(CreateTranscriptionResponseTask left, CreateTranscriptionResponseTask right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateTranscriptionResponseTask"/> values are not the same. </summary>
        public static bool operator !=(CreateTranscriptionResponseTask left, CreateTranscriptionResponseTask right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreateTranscriptionResponseTask"/>. </summary>
        public static implicit operator CreateTranscriptionResponseTask(string value) => new CreateTranscriptionResponseTask(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateTranscriptionResponseTask other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateTranscriptionResponseTask other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}