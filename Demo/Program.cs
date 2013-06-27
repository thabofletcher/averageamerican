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
            var model = Consumer<Coderbits>.ConsumeNow("https://coderbits.com/thabo.json");
            Console.WriteLine(model.views);

            var dynamicModel = Consumer<dynamic>.ConsumeNow("https://coderbits.com/thabo.json");
            Console.WriteLine(dynamicModel.views);

            Console.Read();
        }
    }
}
