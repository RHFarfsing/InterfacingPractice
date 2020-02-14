using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacing {
    class Hello {
        ISpeakable Language;
        public void Speak() {
            Console.WriteLine($"Ready! : {Language.GetMessage(0)}");
            Console.WriteLine($"Hello : {Language.GetMessage(1)}");
            Console.WriteLine($"Goodbye : {Language.GetMessage(2)}");
            Console.WriteLine($"Error: {Language.GetMessage(3)}");

        }
        public Hello(ISpeakable language) {
            Language = language;
        }
    }
}
