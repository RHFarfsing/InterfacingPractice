using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacing {
    class HelloInPirate : ISpeakable{
        Dictionary<int, string> messages = new Dictionary<int, string> {
            [0] = "Ready!",
            [1] = "A hoy",
            [2] = "Goodbye",
            [9999] = "Message number not found"
        };

        public void SayHello() {
            Console.WriteLine("A hoy");
        }
        public void SayGoodbye() {
            Console.WriteLine("Goodbye");
        }


    }
}
