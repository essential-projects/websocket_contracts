namespace EssentialProjects.WebSocket.Contracts
{
    /// <summary>
    /// Wraps a message with context information to identify its type and usage.
    /// </summary>
    public class MessageEnvelope<TMessage>
    {
        /// <summary>
        /// The specific message instance wrapped by the envelope.
        /// </summary>
        /// <value>The message</value>
        public TMessage Message { get; set; }

        /// <summary>
        /// The event type used to send and subscribe to the message.
        /// </summary>
        /// <value>The event type identifier</value>
        public string EventType { get; set; }
        /// <summary>
        /// The name of the channel used to transport the message.
        /// </summary>
        /// <value>The channel name</value>
        public string ChannelName { get; set; }

        /// <summary>
        /// Creates a new message envelope.
        /// </summary>
        /// <param name="message">
        /// The specific message instance wrapped by the envelope.
        /// </param>
        /// <param name="eventType">
        /// The event type used to send and subscribe to the message.
        /// </param>
        /// <param name="channelName">
        /// The name of the channel used to transport the message.
        /// </param>
        public MessageEnvelope(
            TMessage message,
            string eventType,
            string channelName)
        {
            this.Message = message;
            this.EventType = eventType;
            this.ChannelName = channelName;
        }
    }
}
