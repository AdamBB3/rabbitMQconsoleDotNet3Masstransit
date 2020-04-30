using MassTransit;
using MessageCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReceveurCore
{
    public class MessageConsumer : IConsumer<Message>
    {
        public async Task Consume(ConsumeContext<Message> context)
        {
            await Console.Out.WriteLineAsync($"message reçu : {context.Message.Name}");
        }
    }
}
