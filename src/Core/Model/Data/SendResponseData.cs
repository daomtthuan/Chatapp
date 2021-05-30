namespace Chatapp.Core.Model.Data {
  public class SendResponseData : IData {
    public bool Result { get; private set; }

    public SendResponseData(bool result) {
      this.Result = result;
    }
  }
}
