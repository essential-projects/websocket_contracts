namespace EssentialProjects.WebSocket.Contracts
{
    using System;
    using System.Threading;

    /// <summary>
    /// The socket client encapsulates the communication with a single connected
    /// socket endpoint.
    /// </summary>
    public interface ISocketClient : IDisposable
    {
        /// <summary>
        /// Registers a message type for the supplied event type.
        /// When a message is received for the supplied event type, it will be
        /// deserialized to the supplied message type.
        /// </summary>
        /// <param name="eventType">
        /// The event type to register the message type for.
        /// </param>
        /// <typeparam name="TMessageType">
        /// The message type to be registered for the supplied event type.
        /// </typeparam>
        void RegisterMessageType<TMessageType>(string eventType);

        /// <summary>
        /// Starts listening for messages on the configured connection.
        /// </summary>
        /// <param name="cancellationToken">
        /// The CancellationToken used to stop listening.
        /// </param>
        /// <returns>
        /// A task that is running while the client is listening for messages.
        /// </returns>
        Task StartListening(CancellationToken cancellationToken);

        // /// <summary>
        // /// Sends a message to the connected socket endpoint using the supplied
        // /// event type.
        // /// </summary>
        // /// <typeparam name="TMessage">The message to be sent.</typeparam>
        // void Emit<TMessage>(string eventType, TMessage message)
        //     where TMessage : class;

        /// <summary>
        /// Subscribes to the given event type and executes the supplied
        /// callback each time a message is received.
        /// </summary>
        /// <typeparam name="TMessage">The message to be received.</typeparam>
        Subscription On<TMessage>(string eventType, Action<TMessage> callback)
            where TMessage : class;

        /// <summary>
        /// Subscribes to the given event type and executes the supplied
        /// callback once when the first message is received.
        /// </summary>
        /// <typeparam name="TMessage">The message to be received.</typeparam>
        Subscription Once<TMessage>(string eventType, Action<TMessage> callback)
            where TMessage : class;
    }
}
