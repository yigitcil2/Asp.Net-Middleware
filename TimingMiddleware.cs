namespace MiddlewareDemo
{
    public class TimingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<TimingMiddleware> _logger;
        public TimingMiddleware(ILogger<TimingMiddleware> logger, RequestDelegate next)
        {
            _logger = logger;
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            var start = DateTime.UtcNow;
            await _next.Invoke(context);
            _logger.LogInformation($"Timing: {(DateTime.UtcNow - start).TotalMilliseconds}");
        }
    }
}