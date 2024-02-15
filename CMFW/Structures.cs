namespace Framework.Structures
{
    internal interface IRegisteredScript
    {
        internal void Recieve();
    }

    internal class Message
    {
        public object Sender { get; set; }
        public object Content { get; set; }
        public object Target { get; set; }

        internal Message(object sender, object content, object target)
        {
            Sender = sender;
            Content = content;
            Target = target;
        }
    }
}