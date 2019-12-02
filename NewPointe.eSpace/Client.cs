using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using NewPointe.Util;
using NewPointe.Util.QueryString;
using NewPointe.eSpace.Models;
using System.Collections.Generic;

namespace NewPointe.eSpace
{
    public class Client
    {

        private readonly HttpClient client;

        public Client() : this(new HttpClient()) { }

        public Client(string apiServer) : this(new Uri(apiServer)) { }

        public Client(Uri apiServer) : this(new HttpClient(), apiServer) { }

        public Client(HttpClient client) : this(client, "https://api.espace.cool") { }

        public Client(HttpClient client, string apiServer) : this(client, new Uri(apiServer)) { }

        public Client(HttpClient client, Uri apiServer)
        {
            this.client = client;
            client.BaseAddress = HttpUtil.EnsureTrailingSlash(apiServer);
            client.DefaultRequestHeaders.Add("User-Agent", GetType().FullName + "/" + GetType().Assembly.GetName().Version.ToString());
        }

        public void SetCredentials(string username, string password) {
            byte[] authBytes = Encoding.ASCII.GetBytes(username + ":" + password);
            string authBytesEncoded = Convert.ToBase64String(authBytes);
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authBytesEncoded);
        }

        private Task<T> GetAsync<T>(string url, Dictionary<string, dynamic> queryParams) {
            return this.GetAsync<T, Dictionary<string, dynamic>>(url, queryParams);
        }

        private Task<T> GetAsync<T, U>(string url, U queryObject) where U : class {
            return this.GetAsync<T>(url + QueryStringFormatter<U>.Serialize(queryObject));
        }

        private async Task<T> GetAsync<T>(string url) {
            HttpResponseMessage response = await client.GetAsync(url);
            if(response.IsSuccessStatusCode) {
                ApiResponseSuccess<T> responseData = await response.Content.ReadAsAsync<ApiResponseSuccess<T>>();
                return responseData.Data;
            }
            else {
                ApiResponseFail responseData = await response.Content.ReadAsAsync<ApiResponseFail>();
                throw new ClientHttpException(responseData.Message, response);
            }
        }

        public Task<Event> GetEvent(int eventId, int scheduleId) {
            return this.GetAsync<Event>("api/v1/event", new Dictionary<string, dynamic> {
                { "eventId", eventId },
                { "scheduleId", scheduleId }
            });
        }

        public Task<Event[]> GetEvents() => GetEvents(null);

        public Task<Event[]> GetEvents(GetEventsOptions options) {
            return this.GetAsync<Event[], GetEventsOptions>("api/v1/event/list", options);
        }

        public Task<Occurrence[]> GetEventOccurrences() => GetEventOccurrences(null);

        public Task<Occurrence[]> GetEventOccurrences(GetEventOccurrencesOptions options) {
            return this.GetAsync<Occurrence[], GetEventOccurrencesOptions>("api/v1/event/occurrences", options);
        }

        public Task<EventItem[]> GetEventSpaces(int eventId, int scheduleId) {
            return this.GetAsync<EventItem[]>("api/v1/event/spaces", new Dictionary<string, dynamic> {
                { "eventId", eventId },
                { "scheduleId", scheduleId }
            });
        }

        public Task<EventItem[]> GetEventResources(int eventId, int scheduleId) {
            return this.GetAsync<EventItem[]>("api/v1/event/resources", new Dictionary<string, dynamic> {
                { "eventId", eventId },
                { "scheduleId", scheduleId }
            });
        }

        public Task<EventItem[]> GetEventServices(int eventId, int scheduleId) {
            return this.GetAsync<EventItem[]>("api/v1/event/services", new Dictionary<string, dynamic> {
                { "eventId", eventId },
                { "scheduleId", scheduleId }
            });
        }

        public Task<Item[]> GetItems() => GetItems(null);

        public Task<Item[]> GetItems(GetItemsOptions options) {
            return this.GetAsync<Item[], GetItemsOptions>("api/v1/item/list", options);
        }

        public Task<Category[]> GetCategories() {
            return this.GetAsync<Category[]>("api/v1/ministry/categories");
        }

        public Task<Location[]> GetLocations() {
            return this.GetAsync<Location[]>("api/v1/ministry/locations");
        }

        public Task<Editor[]> GetEditors() {
            return this.GetAsync<Editor[]>("api/v1/ministry/editors");
        }

        public Task<User[]> GetUsers() {
            return this.GetAsync<User[]>("api/v1/ministry/users");
        }

        public Task<Webhook[]> GetWebhooks() {
            return this.GetAsync<Webhook[]>("api/v1/webhook/list");
        }

        public Task<Webhook[]> GetWebhooks(int id) {
            return this.GetAsync<Webhook[]>("api/v1/webhook/list", new Dictionary<string, dynamic> {
                { "id", id }
            });
        }

        public Task<WebhookEventType[]> GetWebhookEvents() {
            return this.GetAsync<WebhookEventType[]>("api/v1/webhook/webhookevents");
        }

    }
}
