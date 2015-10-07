using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace eTemple.Data.Utilities
{
    public class SMSHelper
    {
        public void sendSMS(string phone, string smsMessage)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["SvcpvdrAPI"]);
            // Usage
            HttpResponseMessage response = client.GetAsync("?User=" + ConfigurationManager.AppSettings["User"] +
                "&passwd=" + ConfigurationManager.AppSettings["passwd"] + "&mobilenumber=" + phone + "&message=" +
                smsMessage + "&sid=" + ConfigurationManager.AppSettings["sid"] +
                "&mtype=" + ConfigurationManager.AppSettings["mtype"] + "&DR=" + ConfigurationManager.AppSettings["DR"] + "").Result;
        }
    }
}
