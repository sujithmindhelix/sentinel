using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization.Json;
using Microsoft.Http;
using System.Net.Mail;
using System.Security.Cryptography;

namespace Console_Http
{
    public class sample
    {

        public string authkey { get; set; }
        public string authtoken { get; set; }
            
    }
    class Program
    {
      public  void  webClient_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            //// Gets the original url passed.
            //sample p = new sample();
            //Stream s = e.Result;
            //StreamReader strReader = new StreamReader(s);

            //List<sample> prat = new List<sample>();

            //JsonTextReader reader = new JsonTextReader(strReader);

            //JArray root = JArray.Load(reader);

            //foreach (JObject o in root)
            //{

            // string authkey = (string)o["authkey"];

            // string authtoken = (string)o["authtoken"];
            //}


        }
     public void sendmail()
      {
          
      }
     public string encryptpass(string password)
     {
         string text = password;
         UnicodeEncoding UE = new UnicodeEncoding();
         byte[] hashValue;
         byte[] message = UE.GetBytes(text);
         MD5 hashString = new MD5CryptoServiceProvider();
         string hex = "";
         hashValue = hashString.ComputeHash(message);
         foreach (byte x in hashValue)
         {
             hex += String.Format("{0:x2}", x);

         }
         return hex;
     }
        static void Main(string[] args)
        {

            TimeSpan t1 = TimeSpan.FromSeconds(Convert.ToDouble("180"));

          TimeSpan t2 = TimeSpan.Parse(System.DateTime.Now.ToString("HH:mm"));
            //TimeSpan t3 = t1 + t2;
            int MyRandomNumber = 1111;
            //System.Random RandNum = new System.Random();
            //MyRandomNumber = RandNum.Next(9999);
            //string n = MyRandomNumber.ToString();
            //while (n.Length !=4)
            //{
            //     n = MyRandomNumber.ToString();
            //}
          //string x="";
            ////LOGIN
            //string uri = "http://127.0.0.1:8080/api/Login";
            //sevicetest s = new sevicetest();
            //s.User_id = "9744252641";
            //s.Password = "4444";

            //s.Version = "paid";

            //using (HttpResponseMessage response = new HttpClient().Post(uri, HttpContentExtensions.CreateJsonDataContract(s)))
            //{
            //    string res = response.Content.ReadAsString();
            //    res = res.TrimStart(new char[] { '"' }).TrimEnd(new char[] { '"' });
            //    //return res;
            //}

            ///registration
            //string uri = "http://127.0.0.1:8080/api/Register";
            //Registration s = new Registration();
            //s.Email_id = "sujith.jayachandran@mindhelix.com";
            //s.Phone = "4444";
            //s.Password = "nvdcbnvxcszc";
            //s.Name = "sdasd";
            //s.DOB = "sadhbasmhdgbas";
            //s.Sex = "sxdsa";
            //s.Emergency_no1 = "567587";
            //s.Emergency_no2 = "76575877";
            //s.Emergency_no3 = "254454545";
            //s.Emergency_email = "hcbhzxbdchsb";
            //s.IMEI = "767878";

          
            //using (HttpResponseMessage response = new HttpClient().Post(uri, HttpContentExtensions.CreateJsonDataContract(s)))
            //{
            //    string res = response.Content.ReadAsString();
            //    res = res.TrimStart(new char[] { '"' }).TrimEnd(new char[] { '"' });
            //    //return res;
            //}

            //logout
            string uri = "http://127.0.0.1:8080/api/Logout";
            logout s = new logout();
            s.Password = "8838";
            WebClient client = new WebClient();

            client.Headers["Content-type"] = "application/json";
            client.Headers.Add("Authkey", "25822795-7e4e-4276-ac20-87ad553063d5");


            using (HttpResponseMessage response = new HttpClient().Post(uri, HttpContentExtensions.CreateJsonDataContract(s)))
            {
                string res = response.Content.ReadAsString();
                res = res.TrimStart(new char[] { '"' }).TrimEnd(new char[] { '"' });
                //return res;
            }

            //............................forgot password............................
            //string uri = "http://127.0.0.1:8080/api/forgotpassword";
            //forgotpassword s = new forgotpassword();
            //s.userid = "sujith.jayachandran@mindhelix.com";
            //using (HttpResponseMessage response = new HttpClient().Post(uri, HttpContentExtensions.CreateJsonDataContract(s)))
            //{
            //    string res = response.Content.ReadAsString();
            //    res = res.TrimStart(new char[] { '"' }).TrimEnd(new char[] { '"' });
            //    //return res;
            //}
           //---------------------------PING------------------------------------
            //string uri = "http://127.0.0.1:8080/api/Ping";
            //PingDetails s = new PingDetails();
            //s.Authkey = "90dc97b4-d37c-4995-894a-528863c08f0c";
            //s.Latitude = "9.00526";
            //s.Longitude = "8.21356";
            //s.Direction = "";
            //s.Speed = "";
            //s.Next_Ping = "";
            //s.Current_time = System.DateTime.Now.ToShortDateString();
            //s.Battery_Life = "low";
            //s.flag = "ping";
            //using (HttpResponseMessage response = new HttpClient().Post(uri, HttpContentExtensions.CreateJsonDataContract(s)))
            //{
            //    string res = response.Content.ReadAsString();
            //    res = res.TrimStart(new char[] { '"' }).TrimEnd(new char[] { '"' });
            //    //return res;
            //}
            //------------------------------alert........................
            //string uri = "http://127.0.0.1:8080/api/Alert";
            //AlertDetails s = new AlertDetails();
            //s.Authkey = "90dc97b4-d37c-4995-894a-528863c08f0c";
            //s.Latitude = "9.00526";
            //s.Longitude = "8.21356";
            //s.Direction = "";
            //s.Speed = "";
            //s.Next_Ping = "";
            //s.Current_time = System.DateTime.Now.ToShortDateString();
            //s.Battery_Life = "low";
            //s.Alertflag = "Button";
            //using (HttpResponseMessage response = new HttpClient().Post(uri, HttpContentExtensions.CreateJsonDataContract(s)))
            //{
            //    string res = response.Content.ReadAsString();
            //    res = res.TrimStart(new char[] { '"' }).TrimEnd(new char[] { '"' });
            //    //return res;
            //}
            //------------------------------safe alert-------------------
            //string uri = "http://127.0.0.1:8080/api/Alert";
            //AlertDetails s = new AlertDetails();
            //s.Authkey = "90dc97b4-d37c-4995-894a-528863c08f0c";
            //s.Latitude = "9.00526";
            //s.Longitude = "8.21356";
            //s.Direction = "";
            //s.Speed = "";
            //s.Next_Ping = "";
            //s.Current_time = System.DateTime.Now.ToShortDateString();
            //s.Battery_Life = "low";
            //s.Alertflag = "Safe";
            //using (HttpResponseMessage response = new HttpClient().Post(uri, HttpContentExtensions.CreateJsonDataContract(s)))
            //{
            //    string res = response.Content.ReadAsString();
            //    res = res.TrimStart(new char[] { '"' }).TrimEnd(new char[] { '"' });
            //    //return res;
            //}
           
//.........................................GetSETTINGS.........................................

            //string uri = "http://127.0.0.1:8080/api/GetSettings";
            //using (HttpResponseMessage response = new HttpClient().Post(uri, HttpContentExtensions.CreateJsonDataContract("90dc97b4-d37c-4995-894a-528863c08f0c")))
            //{
            //    string res = response.Content.ReadAsString();
            //    res = res.TrimStart(new char[] { '"' }).TrimEnd(new char[] { '"' });
            //    //return res;
            //}

//..............................................update settings.............................
           // string t = "180";
           // TimeSpan t1 = TimeSpan.FromSeconds(Convert.ToDouble(t));
           //// DateTime  s =DateTime.Parse("180 seconds");
           // string  dt = DateTime.Now.ToLongTimeString();
           // TimeSpan t2 = TimeSpan.Parse(dt);
           // TimeSpan t3 = t2 + t1;
           // TimeSpan ctime=TimeSpan.Parse(DateTime.Now.ToLongTimeString());
           // if (ctime > t3)
           // { 
           //     //
           // }
            //var limit = DateTime.Now.AddMinutes(-3);
            //string uri = "http://127.0.0.1:8080/api/UpdateSetting";
            //Registration s = new Registration();
            //s.authkey = "90dc97b4-d37c-4995-894a-528863c08f0c";
            //s.Phone = "98476426512";
            //s.password = "5555";
            //s.Email_id = "ram@gmail.com";
            //s.Emergency_email = "kkk@gmail.com";
            //s.Emergency_no1 = "8745654521";
            //s.Emergency_no2 = "8745654522";
            //s.Emergency_no3 = "8745654522";
            //s.DOB = "30/05/1986";
            //s.IMEI = "12345";
            //s.Name = "Sree Ram";
            //s.Sex = "Male";
            //using (HttpResponseMessage response = new HttpClient().Post(uri, HttpContentExtensions.CreateJsonDataContract(s)))
            //{
            //    string res = response.Content.ReadAsString();
            //    res = res.TrimStart(new char[] { '"' }).TrimEnd(new char[] { '"' });
            //    //return res;
            //}
           


            //GETMANDALS
           // Console.WriteLine("enter port no:");
           // string port = Console.ReadLine();
           //  string uri = "http://127.0.0.1:" + port;
           //// string uri = "http://apserp.cloudapp.net";

           // WebClient client = new WebClient();
           // MemoryStream ms = new MemoryStream();
           // client.Headers["Content-type"] = "application/json";
           // client.Headers.Add("userkey","53893cf1-e4e6-498b-b5f5-e27c2ecf1330");
           //client.DownloadString(uri + "/APSERPService.svc/GetMandals");

            //using (HttpResponseMessage response = new HttpClient().Get(uri + "/APSERPService.svc/GetMandals"))
            //{
            //    string res = response.Content.ReadAsString();
            //    //  return res;
            //}

         //getece
            //Console.WriteLine("enter port no:");
            //string port = Console.ReadLine();
            //string uri = "http://127.0.0.1:" + port;

            //WebClient client = new WebClient();
            //MemoryStream ms = new MemoryStream();
            //client.Headers["Content-type"] = "application/json";
            //client.Headers.Add("userkey", "87c53a8e-9dbb-48f6-a282-3889e46cd778");
            //client.DownloadString(uri + "/APSERPService.svc/GetECEcentre/1");



            //GEtstudents
           // Console.WriteLine("enter port no:");
           // string port = Console.ReadLine();
           // string uri = "http://127.0.0.1:" + port;
           // WebClient client = new WebClient();
           // MemoryStream ms = new MemoryStream();
           // client.Headers["Content-type"] = "application/json";
           // client.Headers.Add("userkey", "87c53a8e-9dbb-48f6-a282-3889e46cd778");
           //// client.Headers.Add("eceid", "1");
           // string s = client.DownloadString(uri + "/APSERPService.svc/GetStudents/1");

            //getattendance
           // string s = System.DateTime.Today.ToShortDateString();
           // Console.WriteLine("enter port no:");
           // string port = Console.ReadLine();
           // string uri = "http://127.0.0.1:" + port;
           //// string uri = "http://apserp.cloudapp.net";
           // WebClient client = new WebClient();
           // MemoryStream ms = new MemoryStream();
           // client.Headers["Content-type"] = "application/json";
           // client.Headers.Add("userkey", "2326112e-7b99-4be1-80de-7e8eecae174d");
           // //using (HttpResponseMessage response = new HttpClient().Get(uri + "/APSERPService.svc/GetFullAttendance/1/23-03-2012"))
           // //{
           // //    string res = response.Content.ReadAsString();
           // //    //  return res;
           // //}

           // client.DownloadString(uri + "/APSERPService.svc/GetFullAttendance/1/23-03-2012");

        //    string o = "23-03-2012";
        //    string cdate = System.DateTime.Now.ToShortDateString();
        //    Console.WriteLine("enter port no:");
        //    string port = Console.ReadLine();
        //    string uri = "http://127.0.0.1:" + port;
        //    WebClient client = new WebClient();
        //    MemoryStream ms = new MemoryStream();
        //    client.Headers["Content-type"] = "application/json";
        //    client.Headers.Add("userkey", "2326112e-7b99-4be1-80de-7e8esdfgdsfgvsdecae174d");
        //    attend s = new attend();
        //    IEnumerable<attend> st = null;
        //    IEnumerable<attend> pwa = new List<attend>
        //{
        //        new attend { date = "24-03-2012",
        //    morning = "true",
        //    evening = "false",
        //    sid = "1",userkey = "2326112e-7b99-4be1-80de-7e8eecae174d"
        //   },
        //        new attend {date = "24-03-2012",
        //    morning = "false",
        //    evening = "false",
        //   sid = "2",userkey = "2326112e-7b99-4be1-80de-7e8eecae174d"}
        //};
        //    //attend s = new attend();
            //s.date = "23-03-2012";
            //s.morning = "false";
            //s.evening = "false";
            //s.sid = "1";
            //s.date = "23-03-2012";
            //s.morning = "false";
            //s.evening = "false";
            //s.sid = "2";
            //s.userkey = "2326112e-7b99-4be1-80de-7e8eecae174d";
            //st.AsEnumerable<attend>();
            //using (HttpResponseMessage response = new HttpClient().Post(uri + "/APSERPService.svc/FinalAttendance", HttpContentExtensions.CreateJsonDataContract(pwa)))
            //{
            //    string res = response.Content.ReadAsString();
            //    res = res.TrimStart(new char[] { '"' }).TrimEnd(new char[] { '"' });
            //   // return res;
            //}
            ////// Console.WriteLine(HttpContentExtensions.CreateJsonDataContract(s).ReadAsString());
            //using (HttpResponseMessage response = new HttpClient().Post(uri + "/APSERPService.svc/submit", HttpContentExtensions.CreateJsonDataContract(s)))
            //{
            //    string res = response.Content.ReadAsString();
            //    res = res.TrimStart(new char[] { '"' }).TrimEnd(new char[] { '"' });
            //    //return res;
            //}
           
        }
       
    }
}
