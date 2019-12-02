using System;
using System.Net.Http;
using System.Runtime.Serialization;

namespace NewPointe.eSpace
{
    [Serializable]
    public class ClientHttpException : Exception
    {

        HttpResponseMessage ResponseMessage { get; set; }

        public ClientHttpException() { }

        public ClientHttpException(HttpResponseMessage responseMessage) : base() {
            this.ResponseMessage = responseMessage;
        }

        public ClientHttpException(string message) : base(message) { }

        public ClientHttpException(string message, HttpResponseMessage responseMessage) : base(message) {
            this.ResponseMessage = responseMessage;
        }

        public ClientHttpException(string message, Exception inner) : base(message, inner) { }

        public ClientHttpException(string message, HttpResponseMessage responseMessage, Exception inner) : base(message, inner) {
            this.ResponseMessage = responseMessage;
        }

        protected ClientHttpException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    }
}
