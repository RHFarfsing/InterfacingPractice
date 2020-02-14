using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacing {
    class HelloInSpanish : ISpeakable {
        Dictionary<int, string> messages = new Dictionary<int, string> {
            [0] = "Listo!",
            [1] = "Hola",
            [2] = "Adios",
            [9999] = "Message number not found"
        };

        public void SayHello() {
            Console.WriteLine("Hola");
        }
        public void SayGoodbye() {
            Console.WriteLine("Adios");
        }

    }
}
