using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class Response
    {

        public string getEncode( string s )
        {
            return System.Web.HttpUtility.UrlEncode(s, Encoding.UTF8);
        }
    }
}
