using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ComsumeWebApi
{
    public class HttpCommunication<T> where T : class
    {
        HttpClient client;
        string Url;
        public string ServiceAddress { get; set; }
        public HttpCommunication(string Url)
        {
            this.Url = Url;
            client = new HttpClient();
            client.BaseAddress = new Uri(this.Url);
        }
        public T Post(T PayLoad)
        {
            T result = null;
            var content = new StringContent(JsonConvert.SerializeObject(PayLoad), Encoding.UTF8, "application/json");
            HttpResponseMessage message = client.PostAsync(ServiceAddress, content).Result;
            if (message.IsSuccessStatusCode)
            {
                string json = message.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<T>(json);
            }
            return result;
        }
        public bool Put(int Id, T PayLoad)
        {
            client.DefaultRequestHeaders.Clear();
            var content = new StringContent(JsonConvert.SerializeObject(PayLoad), Encoding.UTF8, "application/json");
            ServiceAddress += $"/{Id}";
            HttpResponseMessage message = client.PutAsync(ServiceAddress, content).Result;
            return message.IsSuccessStatusCode ? true : false;
        }
        public bool Delete(int Id)
        {

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            ServiceAddress += $"/{Id}";
            HttpResponseMessage msg = client.DeleteAsync(ServiceAddress).Result;
            return msg.IsSuccessStatusCode ? true : false;

        }
        public List<T> GetRecords()
        {
            List<T> result = null;
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage message = client.GetAsync(ServiceAddress).Result;
            if (message.IsSuccessStatusCode)
            {
                string json = message.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<IEnumerable<T>>(json).ToList();
            }
            return result;
        }
        public T GetRecord(int Id)
        {
            T result = null;
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            ServiceAddress += $"/{Id}";
            HttpResponseMessage message = client.GetAsync(ServiceAddress).Result;
            if (message.IsSuccessStatusCode)
            {
                string json = message.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<T>(json);
            }
            return result;
        }

    }
}
