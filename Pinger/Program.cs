using System.Net.NetworkInformation;
using System.Text;

// Pinging Google DNS Server

Ping pingSender = new Ping();
PingOptions options = new PingOptions();

options.DontFragment = true;

String data = "Learn to code";
byte[] buffer = Encoding.ASCII.GetBytes(data);
int timeout = 120;
string address = "4.2.2.2";
PingReply reply = pingSender.Send(address, timeout, buffer, options);
if (reply.Status == IPStatus.Success)
{
    Console.WriteLine($"Response: {reply.Status.ToString()}");
    Console.WriteLine($"RoundTrip: {reply.RoundtripTime}");
    Console.WriteLine($"Time to Live: {reply.Options.Ttl}");
    Console.WriteLine($"Buffer Size: {reply.Buffer.Length}");
}