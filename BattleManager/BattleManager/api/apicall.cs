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
    }
}
