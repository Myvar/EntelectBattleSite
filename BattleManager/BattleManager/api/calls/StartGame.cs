using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BattleManager.api.calls
{
    public class StartGame : apicall
    {
        public StartGame()
        {
            URL = "http://~:8080/api/startgame/";
        }

        public override string Execute(HttpListenerRequest request)
        {
            //we need to do match making here
            var dat = GetUrlGets(request.RawUrl);

            return "Wait";
        }
    }
}
