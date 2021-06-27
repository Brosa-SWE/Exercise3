using Exercise3._4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._4
{
    class MyError1 : UserError
    {
        public override string UEMessage()
        {
            return "MyError1 message";
        }
    }
}
