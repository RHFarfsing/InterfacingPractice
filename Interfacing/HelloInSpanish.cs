using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacing {
    class HelloInSpanish : HelloInLanguage {
        protected override void InitDictionary() {
            this.messages.Add(0, "Listo!");
            this.messages.Add(1, "Hola");
            this.messages.Add(2, "Adios");
        }
        public HelloInSpanish() : base(){

        }
    }
}
