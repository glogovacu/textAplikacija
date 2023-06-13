namespace ProjekatTVP
{
    public class User
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _username;
        private string _password;
        private string _role;

        public int Id { get => _id; set => _id = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Role { get => _role; set => _role = value; }

        public override string ToString()
        {
            return "ID:|" + _id + "|First Name:|" + _firstName + "|Last name:|" + _lastName + "|Username:|" + _username + "|Password:|" + _password + "|Role:|" + _role;
        }
    }
}
