using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using BattleManager.api;
using BattleManager.api.calls;

namespace BattleManager
{
    /*
     * Myvar:
     *  How this is gona work hope fully:
     *  player a requests to play - save in quew (if only i could create code like the Q's (STNQ refrince))
     *  player b requests to play - save in quew
     *  
     * do match making:
     * set uid ports for both playes
     * lunche botnet server note: cheazck for server lunche limit
     * set quew status to start for both playes to start
     * player a and b get keys to connect
     * game runs , till finshed
     * replay is saved and and loged om databanks
     * game result is stored in databanks
     * set quew status to start for both playes to wait
     * delet botnet sevrer and restet
     * 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region WebApiShit

        public static int _port = 8080;

        public static List<apicall> calles = new List<apicall>();

        public static string ServerName = "localhost";

        public static List<string> URLS = new List<string>()
        {
            "http://*:" + _port.ToString() + "/"
        };

        WebServer ws = null;

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            /* URLS.Clear();
            foreach(var i in calles)
            {
            //  URLS.Add(i.URL);
            }*/
            ws = new WebServer(SendResponse, URLS.ToArray());
            ws.Run();
            LBL_WEBAPI.Text = "WebAPI: online";
        }

        public static string SendResponse(HttpListenerRequest request)
        {
            // return string.Format("<HTML><BODY>My web page.<br>{0}</BODY></HTML>", DateTime.Now);
            foreach (apicall i in calles)
            {
                if (i.URL.Replace("~", ServerName) == request.Url.ToString().Split('?')[0])
                {
                    return i.Execute(request);
                }
            }

            return "404 not found";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ws.Stop();
            LBL_WEBAPI.Text = "WebAPI: offline";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calles.Add(new Status());
            calles.Add(new StartGame());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ws.Stop();
        }
    }
}
