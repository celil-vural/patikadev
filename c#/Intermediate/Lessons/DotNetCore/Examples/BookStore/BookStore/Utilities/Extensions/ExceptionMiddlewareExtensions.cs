using Entity.Concrete.ErrorModels;
using Microsoft.AspNetCore.Diagnostics;
using Services.Contracts;

namespace BookStore.Utilities.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this WebApplication app, ILoggerService logger)
        {
            app.UseExceptionHandler(appErr =>
            {
                appErr.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        context.Response.StatusCode = contextFeature.Error switch
                        {
                            _ => StatusCodes.Status500InternalServerError
                        };
                        var err = new ErrorDetails()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = contextFeature.Error.Message
                        };
                        await context.Response.WriteAsync(err.ToString());
                        logger.Error(err.ToString());
                    }
                });
            });
        }
    }
}
