// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Batch
{
    internal readonly partial struct InternalBatchJobStatus : IEquatable<InternalBatchJobStatus>
    {
        private readonly string _value;

        public InternalBatchJobStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ValidatingValue = "validating";
        private const string FailedValue = "failed";
        private const string InProgressValue = "in_progress";
        private const string FinalizingValue = "finalizing";
        private const string CompletedValue = "completed";
        private const string ExpiredValue = "expired";
        private const string CancellingValue = "cancelling";
        private const string CancelledValue = "cancelled";

        public static InternalBatchJobStatus Validating { get; } = new InternalBatchJobStatus(ValidatingValue);
        public static InternalBatchJobStatus Failed { get; } = new InternalBatchJobStatus(FailedValue);
        public static InternalBatchJobStatus InProgress { get; } = new InternalBatchJobStatus(InProgressValue);
        public static InternalBatchJobStatus Finalizing { get; } = new InternalBatchJobStatus(FinalizingValue);
        public static InternalBatchJobStatus Completed { get; } = new InternalBatchJobStatus(CompletedValue);
        public static InternalBatchJobStatus Expired { get; } = new InternalBatchJobStatus(ExpiredValue);
        public static InternalBatchJobStatus Cancelling { get; } = new InternalBatchJobStatus(CancellingValue);
        public static InternalBatchJobStatus Cancelled { get; } = new InternalBatchJobStatus(CancelledValue);
        public static bool operator ==(InternalBatchJobStatus left, InternalBatchJobStatus right) => left.Equals(right);
        public static bool operator !=(InternalBatchJobStatus left, InternalBatchJobStatus right) => !left.Equals(right);
        public static implicit operator InternalBatchJobStatus(string value) => new InternalBatchJobStatus(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalBatchJobStatus other && Equals(other);
        public bool Equals(InternalBatchJobStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}
