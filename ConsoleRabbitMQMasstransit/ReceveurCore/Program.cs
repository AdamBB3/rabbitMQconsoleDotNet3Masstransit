using MassTransit;
using MessageCore;
using System;

namespace ReceveurCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bus = Bus.Factory.CreateUsingRabbitMq(connectionParam => {

                var host = connectionParam.Host(new Uri("rabbitmq://localhost/"), h => { h.Username("guest"); h.Password("guest"); });
                connectionParam.ReceiveEndpoint(host, "new_queue", e=> {
                     e.Consumer<MessageConsumer>();
                });
            });

            bus.Start();
            Console.WriteLine(" press any key to exit !");
            Console.ReadKey();
            bus.Stop();
        }
    }
}
