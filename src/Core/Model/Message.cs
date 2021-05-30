using Chatapp.Core.Model.Data;
using System;

namespace Chatapp.Core.Model {
  public class Message {
    public Enum Flag { get; private set; }
    public IData Data { get; private set; }

    public Message(Enum flag, IData data) {
      this.Flag = flag;
      this.Data = data;
    }
  }
}
