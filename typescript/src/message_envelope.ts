/**
 * A WebSocket endpoint that clients can connect to.
 */
export class MessageEnvelope<TMessage> {

  /**
   * The specific message instance wrapped by the envelope.
   */
  public message: TMessage;

  /**
   * The event type used to send and subscribe to the message.
   */
  public eventType: string;

  /**
   * The name of the channel used to transport the message.
   */
  public channelName: string;

  constructor(message: TMessage, eventType: string, channelName: string) {
    this.message = message;
    this.eventType = eventType;
    this.channelName = channelName;
  }
}
