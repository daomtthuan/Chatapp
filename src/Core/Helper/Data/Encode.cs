using Chatapp.Core.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Chatapp.Core.Helper.Data {
  public static class Encode {
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
