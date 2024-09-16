using System;
using Microsoft.Azure.Functions.Worker.Extensions.Abstractions;

[assembly: ExtensionInformation("Storyteller.Azure.WebJobs.Extensions.HttpTelemetry", "1.0.0")]

namespace Storyteller.Azure.Functions.Worker.Extensions.HttpTelemetry
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class HttpTelemetryAttribute : InputBindingAttribute
    {
    }
}