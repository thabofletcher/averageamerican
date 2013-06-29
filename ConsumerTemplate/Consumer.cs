using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AverageAmerican
{
    public class Dynamo : Consumer<dynamic>
    {
        public Dynamo(string username = null, string password = null) : base(username, password) { }
    }

    public class Consumer<T>
    {
        private string _BasicAuthHeaderValue = null;

        public Consumer(string username = null, string password = null)
        {
            _BasicAuthHeaderValue = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(username + ":" + password));
        }

        /// <summary>
        /// Asynchronously request the JSON resource at the specified path
        /// </summary>
        /// <param name="path">The URI of the resource being requested</param>
        public async Task<T> ConsumeAsync(string path)
        {
            //Create HttpClient for making request for profile
            var client = new HttpClient();

            if (_BasicAuthHeaderValue != null)
                client.DefaultRequestHeaders.Add("Authorization", _BasicAuthHeaderValue);

            client.DefaultRequestHeaders.Add("Accept", "application/json");

            //Get response as a JSON string
            var jsonString = await client.GetStringAsync(path).ConfigureAwait(continueOnCapturedContext: false);

            //Convert JSON string to model
            T model = await JsonConvert.DeserializeObjectAsync<T>(jsonString);

            //Return the model
            return model;
        }

        /// <summary>
        /// Synchronously request the JSON resource at the specified path
        /// </summary>
        /// <param name="path">The URI of the resource being requested</param>
        public T Consume(string path)
        {
            return ConsumeAsync(path).Result;
        }
    }
}
