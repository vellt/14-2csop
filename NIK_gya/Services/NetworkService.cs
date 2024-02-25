using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace NIK_gya.Services
{
    // osztály/class (publikusra állítva)
    public class NetworkService
    {
        string url; // mező/field (privát alapból)
        // kontruktor, azaz dedikált inicializáló metódus
        public NetworkService(string url)
        {
            // a paraméterből kapott url változó értékét átadjuk
            // az osztályon belüli url mezőnek
            this.url = url; 
        }
        public List<T> GET<T>()
        {
            var request = WebRequest.Create(this.url);
            request.Method = "GET";
            var response = request.GetResponse();
            string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return JsonConvert.DeserializeObject<List<T>>(json);
        }

    }
}
