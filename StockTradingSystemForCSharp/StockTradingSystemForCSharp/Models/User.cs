using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace StockTradingSystemForCSharp.Models
{
    public class User
    {
        public int ID { get; set; }
        [DisplayName("ユーザ名")]
        public string UserName { get; set; }
        [DisplayName("ユーザID")]
        public string UserID { get; set; }
        [DisplayName("パスワード")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}