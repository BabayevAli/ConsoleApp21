
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ConsoleApp21.Log;

using Newtonsoft.Json;

namespace ConsoleApp21
{

    public class Program
    {

        static void Main(string[] args)
        {

            new Api(@"https://www.bakubus.az/az/ajax/apiNew1").getAllDataCountry();
        }
    }


    public class Attributes
    {
        public string BUS_ID { get; set; }
        public string PLATE { get; set; }
        public string DRIVER_NAME { get; set; }
        public string CURRENT_STOP { get; set; }
        public string PREV_STOP { get; set; }
        public string SPEED { get; set; }
        public string BUS_MODEL { get; set; }
        public string LATITUDE { get; set; }
        public string LONGITUDE { get; set; }
        public string ROUTE_NAME { get; set; }
        public string LAST_UPDATE_TIME { get; set; }
        public string DISPLAY_ROUTE_CODE { get; set; }
        public string SVCOUNT { get; set; }
    }

    public class BUS
    {
        public Attributes __invalid_name__@attributes { get; set; }
    }

    public class RootObject
    {
        public List<BUS> BUS { get; set; }
    }

public class Api
{
    string path;

    public Api(string Path)
    {
        path = Path;
    }

    public void getAllDataCountry()
    {
        HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(path));

        WebReq.Method = "GET";

        HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

        Console.WriteLine(WebResp.StatusCode);
        Console.WriteLine(WebResp.Server);

        string jsonString;
        using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
        {
            StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
            jsonString = reader.ReadToEnd();
        }
        Console.WriteLine(jsonString);
        var items = JsonConvert.DeserializeObject<List<Bus>>(jsonString);
    }



}
}
