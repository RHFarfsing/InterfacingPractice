using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacing {
    class HelloInFrench : ISpeakable {
        Dictionary<int, string> messages = new Dictionary<int, string> {
            [0] = "Pret!",
            [1] = "Bonjour",
            [2] = "Au revior",
            [9999] = "Message number not found"
        };

        public void SayHello() {
            Console.WriteLine("Bonjour");
        }
        public void SayGoodbye() {
            Console.WriteLine("Au revior");
        }


    }
}