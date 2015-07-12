using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using BattleManager.api;
using BattleManager.api.calls;

namespace BattleManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static  List<apicall> calles = new List<apicall>();

        public static  List<string> URLS = new List<string>()
        {
           // "http://localhost:8080/keys/req/"
        };


        WebServer ws = null;

        private void button1_Click(object sender, EventArgs e)
        {
            URLS.Clear();
            foreach(var i in calles)
            {
                URLS.Add(i.URL);
            }
            ws = new WebServer(SendResponse, URLS.ToArray());
            ws.Run();
            LBL_WEBAPI.Text = "WebAPI: online";
        }

        public static string SendResponse(HttpListenerRequest request)
        {
            // return string.Format("<HTML><BODY>My web page.<br>{0}</BODY></HTML>", DateTime.Now);

            foreach (apicall i in calles)
            {
                if(i.URL == request.Url.ToString())
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
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ws.Stop();
        }
    }
}
