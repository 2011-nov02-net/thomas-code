using System;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MessageSErvice: Sending a text message...");
        }
    }
}