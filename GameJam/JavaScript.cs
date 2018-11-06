using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdgeJs;

namespace GameJam
{
    class JavaScript
    {
        public void Update()
        {

        }
        public static async Task Start()
        {

            string name = "gal";
            var func = Edge.Func(@"
              var a =[];
                a.push('a');
            return function (data, callback) {
                callback(null, data);
            }
        ");

            Console.WriteLine(await func("js running"));
        }

    }
}
