namespace GroupChat
{
    public class Sender : PersonBase
    {
        public Sender(string Name, string Phone, string SendingMessageTo, string Message)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.SendingMessageTo = SendingMessageTo;
            this.Message = Message;
            groupChat.ReceiverReceivingMessage += NewReceivingMessage;

        }

        public string SendingMessageTo { get; set; }

        public void NewReceivingMessage(Receiver receiver)
        {
            if (receiver.ReceivingFrom == SendingMessageTo)
            {
                Console.WriteLine(this.Name + ": " + this.Message);
                groupChat.ReceiverReceivingMessage -= NewReceivingMessage;
            }
        }
    }
}
