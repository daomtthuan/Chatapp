using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Chatapp.ChatappCore.DataHelpers {
  public static class MessageEncode {
    public static byte[] Serialize(Message message) {
      using (var stream = new MemoryStream()) {
        var formatter = new BinaryFormatter();
        formatter.Serialize(stream, message);
        return stream.ToArray();
      }
    }

    public static Message Deserialize(byte[] tokens) {
      using (var stream = new MemoryStream(tokens)) {
        var formatter = new BinaryFormatter();
        return (Message)formatter.Deserialize(stream);
      }
    }
  }
}
