using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server.Objects
{
    public class Client
    {
        #region Instance variables
        private string name;                // Tên của client
        private Socket socket;              // Socket
        private Thread thread;              // Thread của client
        private EndPoint host;              // Host
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor Client
        /// </summary>
        /// <param name="name">Client name</param>
        /// <param name="socket">Client socket</param>
        /// <param name="thread">Client thread service</param>
        /// <param name="host">Endponit (host)</param>
        public Client(string name, Socket socket, Thread thread, EndPoint host)
        {
            this.Thread = thread;
            this.Host = host;
            this.Name = name;
            this.Socket = socket;
        }
        #endregion

        #region Get Set
        public string Name { get => name; set => name = value; }
        public Socket Socket { get => socket; set => socket = value; }
        public Thread Thread { get => thread; set => thread = value; }
        public EndPoint Host { get => host; set => host = value; }
        #endregion

        #region Methods
        /// <summary>
        /// Override ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Host.ToString() + " : " + Name;
        }
        #endregion
    }
}
