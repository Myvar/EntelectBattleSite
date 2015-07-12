using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BattleManager.api
{
    public abstract class apicall
    {
        public string URL { get; set; }
        public abstract string Execute(HttpListenerRequest request);

        public Dictionary<string,string> GetUrlGets(string raw)
        {
            try
            {
                var z = raw.Split('?');
                var uid = z[z.Length - 1];
                var ret = new Dictionary<string, string>();
                foreach (string x in uid.Split('&'))
                {
                    ret.Add(x.Split('=')[0], x.Split('=')[1]);
                }
                return ret;
            }
            catch(Exception ee)
            {
                return null;
            }
        }
    }
}
