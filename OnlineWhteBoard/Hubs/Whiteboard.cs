using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace OnlineWhteBoard.Hubs
{
    [HubName("whiteBoard")]
    public class Whiteboard : Hub
    {
        public void SendMessage(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
        public void UpdateCanvas(int x, int y, int a, int b)
        {
            Clients.All.createCanvas(x, y, a, b);
        }
        public void EraseCanvas(int x, int y, int a, int b)
        {

        }
    }
}