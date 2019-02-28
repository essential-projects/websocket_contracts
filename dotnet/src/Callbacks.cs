namespace EssentialProjects.WebSocket.Contracts
{
    /// <summary>
    /// The callback executed when a connection has been established.
    /// </summary>
    /// <param name="clientSocket">
    /// The socket instance to communicate with the connected endpoint.
    /// </param>
    public delegate void OnConnectCallback(ISocketClient clientSocket);
}
