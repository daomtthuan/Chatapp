using Chatapp.ChatappCore.DataHelpers.Data;

namespace Chatapp.ChatappCore.DataHelpers {
  public class Message {
    public MessageFlag Flag { get; private set; }
    public IData Data { get; private set; }

    public Message(MessageFlag flag, IData data) {
      Flag = flag;
      Data = data;
    }
  }
}
