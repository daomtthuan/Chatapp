using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class Message
    {
        /// <summary>
        /// Serialize message to tokens byte
        /// </summary>
        /// <param name="message">Sent message</param>
        /// <returns>Tokens array byte</returns>
        public static byte[] Serialize(string message)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, message);
            return stream.ToArray();
        }

        /// <summary>
        /// Deserialize tokens byte to message
        /// </summary>
        /// <param name="tokens">Tokens of received message</param>
        /// <returns>String message</returns>
        public static string Deserialize(byte[] tokens)
        {
            MemoryStream stream = new MemoryStream(tokens);
            BinaryFormatter formatter = new BinaryFormatter();
            return (string)formatter.Deserialize(stream);
        }
    }
}
