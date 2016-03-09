using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SignalR_Chat.Models;

namespace SignalR_Chat
{
    public class ChatServerHub : Hub
    {
        // called from clients 
        public void SendMessage(MessageModel clientModel)
        {
            clientModel.LastUpdatedBy = Context.ConnectionId;

            // broadcast the message to all clients 
            Clients.AllExcept(clientModel.LastUpdatedBy).receiveMessage(clientModel);
        }

    }
}