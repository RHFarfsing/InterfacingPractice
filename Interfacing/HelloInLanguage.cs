using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacing {
    abstract class HelloInLanguage : ISpeakable {
        protected Dictionary<int, string> messages = new Dictionary<int, string> {
            [9999] = "Message number not found."
        };
        protected abstract void InitDictionary();
        public virtual string GetMessage(int messageNumber) {
            if (!messages.ContainsKey(messageNumber))
                return messages[9999];
        } 
           return messages[messageNumber];
    }
}