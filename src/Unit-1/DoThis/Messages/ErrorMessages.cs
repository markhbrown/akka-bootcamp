namespace WinTail.Messages
{
    /// <summary>
    /// Base class for signalling that user input was invalid.
    /// </summary>
    public class InputError
    {
        public string Reason { get; }

        public InputError(string reason)
        {
            Reason = reason;
        }
    }

    /// <summary>
    /// User provided blank input
    /// </summary>
    public class NullInputError : InputError
    {
        public NullInputError(string reason) : base(reason)
        {
        }
    }

    public class ValidationError : InputError
    {
        public ValidationError(string reason) : base(reason)
        {

        }
    }
}
