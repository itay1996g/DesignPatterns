using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginModule
{
    public abstract class LoginBase : ILoginState
    {
        protected Context ctx;

        protected LoginBase(Context ctx)
        {
            this.ctx = ctx;
        }

        public abstract void Login(string password);
    }

}
