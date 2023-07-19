namespace GroupChat
{
    public delegate void SendingMessage(Sender sender);
    public delegate void ReceivingMessage(Receiver receiver);

    public static class groupChat
    {
        public static SendingMessage SenderSendingMessage;
        public static ReceivingMessage ReceiverReceivingMessage;
        
        public static void SendingMessage(Sender sender)
        {
            SenderSendingMessage.Invoke(sender);
        }

        public static void ReceivingMessage(Receiver receiver)
        {
            ReceiverReceivingMessage.Invoke(receiver);
        }

    }
}
