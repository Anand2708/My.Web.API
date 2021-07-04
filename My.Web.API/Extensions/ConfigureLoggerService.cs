using Microsoft.Extensions.DependencyInjection;
using My.Web.LoggerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My.Web.API.Extensions
{
    public static class LoggerMiddlewareExtensions
    {
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}
