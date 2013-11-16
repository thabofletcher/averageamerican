using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace AverageAmerican
{
    public class Dynamo : Consumer
    {
        public Dynamo(string username = null, string password = null) : base(username, password) { }

        public async Task<dynamic> Consume(string path)
        {
            return await base.Consume<dynamic>(path);
        }
    }

    public class Consumer
    {
        private string _BasicAuthHeaderValue = null;

        public Consumer(string username = null, string password = null)
        {
            _BasicAuthHeaderValue = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(username + ":" + password));
        }

        public void IgnoreCertErrors()
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        }

        private HttpClient ClientFactory()
        {
            //Create HttpClient for making request for profile
            var client = new HttpClient();

            if (_BasicAuthHeaderValue != null)
                client.DefaultRequestHeaders.Add("Authorization", _BasicAuthHeaderValue);

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Content-Type", "application/json");
            return client;
        }

        /// <summary>
        /// Asynchronously request (GET) the JSON resource at the specified path
        /// </summary>
        /// <param name="path">The URI of the resource being requested</param>
        public async Task<T> Consume<T>(string path)
        {
            //Get response as a JSON string
            var jsonString = await ClientFactory().GetStringAsync(path).ConfigureAwait(continueOnCapturedContext: false);

            // convert JSON string to model and return the model
            return await JsonConvert.DeserializeObjectAsync<T>(jsonString);
        }

        /// <summary>
        /// DELETE a resource
        /// </summary>
        /// <param name="path">API path with resource identifier</param>
        /// <returns>http response code</returns>
        public async Task<HttpResponseMessage> Destroy(string path)
        {
            return await ClientFactory().DeleteAsync(path).ConfigureAwait(continueOnCapturedContext: false);
        }

        /// <summary>
        /// PUT a resource
        /// </summary>
        /// <param name="path">API path</param>
        /// <param name="newData">The data to associate with the new resource being created</param>
        /// <returns>http response code</returns>
        public async Task<HttpResponseMessage> Manipulate<TData>(string path, TData newData)
        {
            return await ClientFactory().PutAsJsonAsync<TData>(path, newData).ConfigureAwait(continueOnCapturedContext: false);
        }

        /// <summary>
        /// POST a resource
        /// </summary>
        /// <param name="path">API path with resource identifier</param>
        /// <param name="newData">The data to associate with the new resource being updated</param>
        /// <returns>http response code</returns>
        public async Task<HttpResponseMessage> Produce<TData>(string path, TData updateData)
        {
            return await ClientFactory().PostAsJsonAsync<TData>(path, updateData).ConfigureAwait(continueOnCapturedContext: false);
        }
    }
}
