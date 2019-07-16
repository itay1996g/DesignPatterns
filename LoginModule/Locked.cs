using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginModule
{
    class Locked : LoginBase
    {
        public Locked(Context ctx) : base(ctx)
        {
        }

        public override void Login(string password)
        {
            Console.WriteLine("Cant login the computer is locked!");
        }
    }
}
