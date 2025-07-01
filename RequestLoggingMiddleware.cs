public class RequestLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public RequestLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        Console.WriteLine($"İstek alındı: {context.Request.Method} {context.Request.Path}");
        await _next(context);
        Console.WriteLine($"Cevap gönderildi: {context.Response.StatusCode}");
    }
}
