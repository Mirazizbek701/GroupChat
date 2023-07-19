namespace GroupChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            
            List<Sender> senders = new()
            {
                new("Javlon", "1111", "Miraziz", "Nma gap"),
                new("Miraziz", "5459", "Shokir", "Tinch"),
                new("Shokir", "2222", "Javlon", "Salom"),
                new("Mehroj", "7777", "Miraziz", "Kettu")
            };


            List<Receiver> receivers = new()
            {
                new("Miraziz", "5459", "Javlon", "Hello"),
                new("Javlon", "1111", "Shokir", "How r u?"),
                new("Mehroj", "5459", "Javlon", "Lol"),
                new("Shokir", "5459", "Miraziz", "Bye"),
            };

            foreach (Sender sender in senders)
            {
                groupChat.SendingMessage(sender);
            }

            foreach (Receiver receiver in receivers)
            {
                groupChat.ReceivingMessage(receiver);
            }

            groupChat.SendingMessage(new Sender("Javlon", "1111", "Mehroj", "ahahahahahah"));

        }
    }
}
