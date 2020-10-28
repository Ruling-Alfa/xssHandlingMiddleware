using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xssHandlingMiddleware.Middlewares
{
    public static class XssMiddlewareExtension
    {
        public static IApplicationBuilder UseXssBlockingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<XssMiddleware>();
        }
    }
}
