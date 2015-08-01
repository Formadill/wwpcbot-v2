using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wwpcbot_v2.API.OAuth2
{
    class OAuth2
    {
        public volatile static string Key = null;
        public static string GetKey()
        {
            GetKeyForm form = new GetKeyForm();
            string key = null;
            form.ShowDialog();
            key = Key;
            Key = null;
            return key;
        }
    }
}
