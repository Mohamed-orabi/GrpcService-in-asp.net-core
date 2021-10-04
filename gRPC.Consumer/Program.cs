using Grpc.Net.Client;
using GrpcService;
using System;

namespace gRPC.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            Greeter.GreeterClient client = new Greeter.GreeterClient(channel);

            HelloRequest request = new HelloRequest { Name = "Hello My name is Mohamed Orabi" };
            var response =  client.SayHello(request);
            Console.WriteLine("From Grpc Service " + response);
            Console.ReadLine();
        }
    }
}
