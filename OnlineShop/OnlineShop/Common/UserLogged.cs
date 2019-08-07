using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Common
{
    [Serializable]
    public class UserLogged
    {
        public long UserID { get; set; }
        public string UserName { get; set; }


    }
}