using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBox___DataPortal.Dtos
{
    internal class LoginRequest
    {
        public LoginRequest() { }
        public string user_name { get; set; }
        public string password { get; set; }
    }
}
