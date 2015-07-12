using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BattleManager.api.calls
{
    public class Status : apicall
    {
        public Status()
        {
            URL = "http://localhost:8080/api/status/";
        }

        public override string Execute(HttpListenerRequest request)
        {
            return "Good";
        }
    }
}
