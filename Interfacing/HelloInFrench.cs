using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacing {
    class HelloInFrench : HelloInLanguage {
        protected override void InitDictionary() {
            this.messages.Add(0, "Pret!");
            this.messages.Add(1, "Bonjour");
            this.messages.Add(2, "Au revior");
        }
        public HelloInFrench() : base(){

        }
    }
}