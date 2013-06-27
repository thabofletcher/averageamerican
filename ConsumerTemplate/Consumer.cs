using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AverageAmerican
{
    public class Consumer<T>
    {
        public static async Task<T> Consume(string path)
        {
            //Create HttpClient for making request for profile
            var client = new HttpClient();

            //Get response as a JSON string
            var jsonString = await client.GetStringAsync(path).ConfigureAwait(continueOnCapturedContext: false);

            //Convert JSON string to model
            T model = await JsonConvert.DeserializeObjectAsync<T>(jsonString);;

            //Return the model
            return model;
        }

        public static T ConsumeNow(string path)
        {
            return Consume(path).Result;
        }
    }
}
