// using Microsoft.Azure.Functions.Worker;
// using Microsoft.Extensions.Logging;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;

// namespace api;

// public class Hello
// {
//     private readonly ILogger<Hello> _logger;

//     public Hello(ILogger<Hello> logger)
//     {
//         _logger = logger;
//     }

//     [Function("Hello")]
//     public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
//     {
//         _logger.LogInformation("C# HTTP trigger function processed a request.");
//         return new OkObjectResult("Welcome to Azure Functions!");
//     }
// }


using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using System.Net;

namespace Api;

public class Hello
{
    [Function("hello")]
    public async Task<HttpResponseData> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
    {
        var res = req.CreateResponse(HttpStatusCode.OK);
        await res.WriteAsJsonAsync(new { message = "Hello from the API" });
        return res;
    }
}
