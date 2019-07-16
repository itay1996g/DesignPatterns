using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginModule
{
    class LoginFailed : LoginBase
    {
        private int failureCounter;
        public LoginFailed(Context ctx) : base(ctx)
        {
            failureCounter = 1;
        }
        public LoginFailed(Context ctx,int failureCounter) : base(ctx)
        {
            this.failureCounter = failureCounter;
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
                if (this.failureCounter != 3)
                {
                    Console.WriteLine("Wrong password, try again");
                    this.ctx.state = new LoginFailed(ctx, ++failureCounter);
                  
                }
                else
                {
                    Console.WriteLine("Wrong password, Computer is locked!");
                    this.ctx.state = new Locked(ctx);
                }
            }
        }
    }
}
