namespace GroupChat
{
    public class Receiver: PersonBase
    {
        public string ReceivingFrom { get; set; }

        public Receiver(string Name, string Phone, string ReceivingFrom, string Message)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.ReceivingFrom = ReceivingFrom;
            this.Message = Message;

            groupChat.SenderSendingMessage += NewSendingMessage;

        }
        public void NewSendingMessage(Sender sender)
        {
            if (sender.SendingMessageTo == ReceivingFrom)
            {
                Console.WriteLine(this.Name + ": " + this.Message + " (Read)");
                groupChat.SenderSendingMessage -= NewSendingMessage;
            }
        }
    }
}
