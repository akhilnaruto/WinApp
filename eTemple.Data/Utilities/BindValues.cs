using eTemple.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace eTemple.Data.Static
{
    /// <summary>
    /// 
    /// </summary>
    public class BindValues
    {
        private Dictionary<string, string> getBindedValues;
        private eTempleDbDB TempleDb;

        public Dictionary<string,string> getValues(string path)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(path);
            XmlNodeList resources = xml.SelectNodes("English/month");            
            foreach (XmlNode node in resources)
            {
                getBindedValues.Add(node.Attributes["key"].Value, node.InnerText);
            }

            return getBindedValues;
        }
    }
}
