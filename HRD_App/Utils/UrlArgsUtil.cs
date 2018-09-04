using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD_App.Utils
{
    public class UrlArgsUtil
    {
        public static string makeArgs(Dictionary<string, string> args)
        {
            StringBuilder result = new StringBuilder("");
            int i = 0;
            foreach(var arg in args)
            {
                result.Append(arg.Key)
                    .Append('=')
                    .Append(arg.Value);
                i++;
                if (i < args.Count) result.Append('&');
            }
            return result.ToString();
        }
    }
}
