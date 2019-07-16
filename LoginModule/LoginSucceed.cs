using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginModule
{
    class LoginSucceed : LoginBase
    {
        public LoginSucceed(Context ctx) : base(ctx)
        {
        }


        public override void Login(string password)
        {
            Console.WriteLine("You are already logged in");
        }
    }
}
