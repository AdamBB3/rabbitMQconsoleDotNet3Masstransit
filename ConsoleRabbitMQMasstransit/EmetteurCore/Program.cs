using MassTransit;
using MessageCore;
using System;

namespace EmetteurCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
             var bus = Bus.Factory.CreateUsingRabbitMq(connectionParam => {

             var host = connectionParam.Host(new Uri("rabbitmq://localhost:15672"), h => { h.Username("guest"); h.Password("guest"); }); 
             });

            bus.Start();
            bus.Publish(new Message(1, "new Message", DateTime.Now));

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
            bus.Stop();
        }
    }
}
