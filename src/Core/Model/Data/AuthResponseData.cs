using System.Collections.Generic;

namespace Chatapp.Core.Model.Data {
  public class AuthResponseData : IData {
    public bool Result { get; private set; }
    public List<User> Users { get; private set; }

    public AuthResponseData(bool result) {
      this.Users = result ? new List<User>() : null;
    }
  }
}
