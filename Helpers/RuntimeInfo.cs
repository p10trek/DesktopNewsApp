using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesktopNewsApp.Helpers
{
    class RuntimeInfo
    {
        public string GetMethodName()
        {
            var st = new StackTrace();
            var sf = st.GetFrame(0);
            return sf?.GetMethod()?.ToString() ?? string.Empty;
        }
    }
}
