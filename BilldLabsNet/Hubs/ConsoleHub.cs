using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilldLabsNet.Hubs
{
    public class ConsoleHub : Hub
    {
        public void Send(string command)
        {
            var response = "Invalid text.";
            if(string.Equals(command, "white rabbit", StringComparison.OrdinalIgnoreCase))
            {
                response = "How deep does the rabbit hole go?";
            }
            Clients.Caller.updateResponse(response);
        }
    }
}