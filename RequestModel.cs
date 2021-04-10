using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopNewsApp
{
    public class RequestModel
    {
        
        public string Token { get; set; }
        public string Categories { get; set; }
        public string Search { get; set;}
        public int Limit { get; set; }
        public string Url { get; set; }
        public int Timeout { get; set; } = -1;
    }
}
