namespace WinTail.Messages
{
    public class InputSuccess
    {
        public string Reason { get; private set; }

        public InputSuccess(string reason)
        {
            Reason = reason;
        }
    }
}
