using adduo.elephant.api.models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;

namespace adduo.elephant.api.filters
{
    public static class GlobalExceptionMiddlewareExtensions
    {
        public static void AddGlobalExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                    if (contextFeature != null)
                    {
                        var statusCode = HttpStatusCode.InternalServerError;
                        var message = string.Empty;

                        if(contextFeature.Error is ArgumentException ex)
                        {
                            statusCode = HttpStatusCode.BadRequest;
                            message = ex.Message;
                        }

                        context.Response.StatusCode = (int)statusCode;
                        await context.Response.WriteAsync(new ErrorDetail(statusCode, message).ToString());
                    }
                });
            });
        }
    }
}
