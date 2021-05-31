namespace Chatapp.dto
{
    public class Account
    {
        private string name;

        public Account(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; private set => name = value; }

        public override string ToString()
        {
            return name;
        }
    }
}