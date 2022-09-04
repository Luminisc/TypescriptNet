using Microsoft.AspNetCore.NodeServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS0618 // Type or member is obsolete
namespace TypescriptObjectsToCs
{
    internal class NodeSandbox
    {
        public static async Task Test()
        {
            // https://github.com/aspnet/JavaScriptServices/tree/master/src/Microsoft.AspNetCore.NodeServices
            var fileNames = Directory.GetFiles("../../../../NodeSandbox/ts_example")
                .Select(x => Path.GetFullPath(x))
                .ToArray();
            
            INodeServices nodeServices = GetNodeService();
            var result = await nodeServices.InvokeAsync<JArray>("./dotnetEntrypoint.js", fileNames);
            var obj = result[0].ToObject<Class1>();
            await Task.CompletedTask;
        }

        private static INodeServices GetNodeService()
        {
            var services = new ServiceCollection();
            var serviceProvider = services.BuildServiceProvider();
            var options = new NodeServicesOptions(serviceProvider)
            {
                ProjectPath = "../../../../NodeSandbox/",
                EnvironmentVariables = new Dictionary<string, string> 
                {
                    // { "NODE_OPTIONS", "--experimental-specifier-resolution=node --loader ts-node/esm" }
                },
                NodeInstanceOutputLogger = new NodeLogger()
            };
            var nodeServices = NodeServicesFactory.CreateNodeServices(options);
            return nodeServices;
        }
    }

    internal class NodeLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            throw new Exception();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            Console.WriteLine($"[{logLevel}] {state}{(exception != null ? exception.Message : string.Empty)}");
        }
    }
}
#pragma warning restore CS0618 // Type or member is obsolete