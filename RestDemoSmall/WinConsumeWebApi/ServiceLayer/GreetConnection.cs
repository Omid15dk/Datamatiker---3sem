namespace WinConsumeWebApi.ServiceLayer {
    public class GreetConnection {

        public GreetConnection() {
            HttpEnabler = new HttpClient();
            BaseUrl = "https://localhost:7157/api/hellos";
            UseUrl = BaseUrl;
        }

        public HttpClient HttpEnabler { private get; init; }

        public string? BaseUrl { private get; init; }

        public string? UseUrl { get; set; }

        public async Task<HttpResponseMessage> CallServiceAsync() {
            HttpResponseMessage hrm = await HttpEnabler.GetAsync(UseUrl);
            return hrm;
        }

    }
}
