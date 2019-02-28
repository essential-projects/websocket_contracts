namespace EssentialProjects.WebSocket.Contracts
{
    using System;

    /// <summary>
    /// A disposable subscription to an event type on a WebSocket.
    /// </summary>
    public class Subscription : IDisposable
    {
        private Action DisposeCallback;

        /// <summary>
        /// Creates a new subscription than can be disposed.
        /// </summary>
        /// <param name="disposeCallback">
        /// The callback used to dispose the subscription.
        /// </param>
        public Subscription(Action disposeCallback)
        {
            this.DisposeCallback = disposeCallback;
        }

        /// <summary>
        /// Disposes the subscription.
        /// </summary>
        public void Dispose()
        {
            this.DisposeCallback();
        }
    }
}
