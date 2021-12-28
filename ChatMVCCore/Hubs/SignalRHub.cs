using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChatMVCCore.Hubs
{
    public class SignalRHub : Hub
    {
        public Task SendMessage(string receiver, string user, string message)
        {
            return Clients.Client(receiver).SendAsync("ReceiveMessage", user, message);
        }
    }
}