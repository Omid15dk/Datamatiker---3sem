namespace WinConsumeWebApi.ServiceLayer;
public class GreetCall {

    readonly GreetConnection _greetService;

    public GreetCall() {
        _greetService = new GreetConnection();
    }

    public async Task<string?> GetGreeting(string? name = null, int times = int.MinValue) {
        string? strFoundGreeting = null;

        if (!string.IsNullOrEmpty(name)) {
            _greetService.UseUrl += "/" + name;
            if (times > 0) {
                _greetService.UseUrl += "/" + times;
            }
        }

        if (_greetService != null) {
            try {
                HttpResponseMessage apiResponse = await _greetService.CallServiceAsync();
                if (apiResponse.IsSuccessStatusCode) {
                    strFoundGreeting = await apiResponse.Content.ReadAsStringAsync();
                } else {
                    strFoundGreeting = "Service response failure";
                }
            }
            catch {
                strFoundGreeting = "Service call error";
            }
        }

        return strFoundGreeting;
    }

}
