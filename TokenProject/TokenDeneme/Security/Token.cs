using System;

namespace TokenProject.Security
{
    public class Token
    {
        public string AccessToken { get; set; }

        //token bitiş süresi
        public DateTime Expiration { get; set; }


    }
}
