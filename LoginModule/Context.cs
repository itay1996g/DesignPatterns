using System;

namespace LoginModule
{
    public class Context
    {
        public ILoginState state;
        public string correctPassword = "Aa1234567";
        public Context()
        {

        }
        public void Init(ILoginState state)
        {
            this.state = state;
        }

        public void Login(string password)
        {
            state.Login(password);
        }

        public void Restart()
        {
            this.state = new NewLogin(this);
            Console.WriteLine("Restart Succesfully");
        }

    }
}