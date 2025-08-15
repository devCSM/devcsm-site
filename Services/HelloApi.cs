namespace MySite.Services;
public interface IHelloApi { Task<string> GetAsync(); }
public class HelloApi : IHelloApi
{
    private readonly HttpClient _http;
    public HelloApi(HttpClient http) => _http = http;
    public async Task<string> GetAsync() => await _http.GetStringAsync("/api/hello");
}
