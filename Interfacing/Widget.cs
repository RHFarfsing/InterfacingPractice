using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacing {
    class Widget : IPrintable {

        public void Print() {
            Console.WriteLine("Widget");
        }

    }
}
