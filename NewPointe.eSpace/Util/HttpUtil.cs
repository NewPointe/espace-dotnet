using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NewPointe.Util
{
    public static class HttpUtil
    {

        public static string EnsureTrailingSlash(string value) {
            return value.EndsWith("/") ? value : value + "/";
        }
        
        public static Uri EnsureTrailingSlash(Uri value) {
            int lastIndex = value.Segments.Length - 1;
            value.Segments[lastIndex] = EnsureTrailingSlash(value.Segments[lastIndex]);
            return value;
        }

        public static string RemoveTrailingSlash(string value) {
            return value.TrimEnd('/');
        }

        public static Uri RemoveTrailingSlash(Uri value) {
            int lastIndex = value.Segments.Length - 1;
            value.Segments[lastIndex] = RemoveTrailingSlash(value.Segments[lastIndex]);
            return value;
        }

        public static async Task DebugRequest(HttpRequestMessage request){
            
            Console.WriteLine("------------------ HTTP Request ------------------");
            Console.WriteLine("HTTP Version: " + request.Version.ToString());
            Console.WriteLine("Method: " + request.Method.ToString());
            Console.WriteLine("Uri: " + request.RequestUri.ToString());
            Console.WriteLine("Headers:");

            foreach (var header in request.Headers)
            {
                foreach (var val in header.Value)
                {
                    Console.WriteLine("    " + header.Key + ": " + val);
                }
            }

            if(request.Content != null) {
                var content = await request.Content.ReadAsStringAsync();
                Console.WriteLine("Content:");
                Console.WriteLine("");
                Console.WriteLine(content);
                Console.WriteLine("");
            }

            Console.WriteLine("--------------------------------------------------");

        }

        public static async Task DebugResponse(HttpResponseMessage response){

            await DebugRequest(response.RequestMessage);
            
            Console.WriteLine("------------------ HTTP Response -----------------");
            Console.WriteLine("HTTP Version: " + response.Version.ToString());
            Console.WriteLine("Status Code: " + ((int)response.StatusCode).ToString());
            Console.WriteLine("Status Message: " + response.ReasonPhrase.ToString());
            Console.WriteLine("Headers:");

            foreach (var header in response.Headers)
            {
                foreach (var val in header.Value)
                {
                    Console.WriteLine("    " + header.Key + ": " + val);
                }
            }

            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Content:");
            Console.WriteLine("");
            Console.WriteLine(content);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");

        }

    }
}