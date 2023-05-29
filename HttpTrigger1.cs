using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace MyFunctionNamespace
{
    public static class MyFunction
    {
        [FunctionName("MyFunction")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string responseMessage = $"Proyecto de Seguridad 2023 {Guid.NewGuid()}";

            return new OkObjectResult(responseMessage);
        }
    }
}
