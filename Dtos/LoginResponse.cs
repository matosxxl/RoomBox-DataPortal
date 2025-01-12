using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBox___DataPortal.Dtos
{
    internal class LoginResponse
    {

        public LoginResponse() { }
        public string refresh { get; set; }
        public string access { get; set; }
        public string user_type { get; set; }

    }
}
