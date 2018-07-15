using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace Decentralization
{
    public static class Role
    {
        //liệt kê các quyền
        public static bool login;
        public static bool logout;
        public static bool doimk;

        //mặc định
        public static void MacDinh()
        {
            if(Session.Role == "")
            {
                login = true;
                logout = false;
                doimk = false;
            }
            else if(Session.Role =="Admin")
            {
                login = false;
                logout = true;
                doimk = true;
            }
        }
    }
}
