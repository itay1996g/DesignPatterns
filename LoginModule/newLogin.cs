using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginModule
{
    class NewLogin : LoginBase
    {
        public NewLogin(Context ctx) : base(ctx)
        {
        }


        public override void Login(string password)
        {
            if (password == this.ctx.correctPassword)
            {
                Console.WriteLine("Corect Password, Login succesfully");
                this.ctx.state = new LoginSucceed(ctx);
            }
            else
            {
                Console.WriteLine("Wrong password, try again");
                this.ctx.state = new LoginFailed(ctx);
            }
        }
    }
}

