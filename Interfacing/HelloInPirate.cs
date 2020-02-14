using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacing {
    class HelloInPirate : HelloInLanguage{
        protected override void InitDictionary() {
            this.messages.Add(0, "Ready!");
            this.messages.Add(1, "A hoy");
            this.messages.Add(2, "Goodbye");
        }
        public HelloInPirate() : base(){

        }
    }
}
