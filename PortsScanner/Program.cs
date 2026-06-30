using System;
using System.Net.Sockets;

string ipAdd, portInput;

Console.Write("Enter IP address: ");
ipAdd = Console.ReadLine();

Console.Write("Enter port :");
portInput = Console.ReadLine();

if(!int.TryParse(portInput, out int port))
{
    Console.WriteLine("Invalid port");
    return;
}

try
{
    TcpClient client = new TcpClient();
    client.Connect(ipAdd, port);

    Console.WriteLine("Port: " + port + " is open");
    client.Close();
}
catch
{
    Console.WriteLine("Port: " + port + " is closed");
}