using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace WebSocketServer.Middleware{
    public class WebSocketServerConnectionManager{
        private ConcurrentDictionary<string, WebSocket> _sockets = new ConcurrentDictionary<string, WebSocket>();

        public ConcurrentDictionary<string, WebSocket> GetAllSockets(){
            return _sockets;
        }

        public string AddSocket(WebSocket socket, string ConnID)
        {
            //string ConnID = Guid.NewGuid().ToString();

            _sockets.TryAdd(ConnID, socket);

            Console.WriteLine("Connection added: "+ConnID);

            return ConnID;
        }
    
        
    }
}