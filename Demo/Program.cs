using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AverageAmerican;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Consumer().Consume<Coderbits>("https://coderbits.com/thabo.json").Result;
            Console.WriteLine(model.views);

            var dynamicModel = new Dynamo().Consume("https://coderbits.com/thabo.json").Result;
            Console.WriteLine(dynamicModel.views);

            //var testBasicAuth = new Dynamo("user1", "user1").Consume("http://test.webdav.org/auth-basic/");

            Console.Read();
        }
    }
}
