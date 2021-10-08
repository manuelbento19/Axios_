using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace MB_API
{
    public class Axios
    {
        #region Mêtodo GET 
        public dynamic Get(string url)
        {
                var client = new RestClient(url);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                return JsonConvert.DeserializeObject(response.Content);
        }
        #endregion
        #region Mêtodo POST
        public dynamic Save(string url,dynamic body)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(body);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject(response.Content);
        }
        #endregion
        #region Mêtodo PUT
        public dynamic Udpate(string url,dynamic body)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.PUT);
            request.AddJsonBody(body);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject(response.Content);
        }
        #endregion
        #region Mêtodo DELETE
        public dynamic Delete(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.DELETE);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject(response.Content);

        }
        #endregion
    }
}