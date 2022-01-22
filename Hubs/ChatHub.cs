using System.Net.Http;
using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    // Hubs handle Client-Server Communication - a SingalR base class
    public class ChatHub : Hubs
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        
    }
}