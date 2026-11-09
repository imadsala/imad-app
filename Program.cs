var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();

var app = builder.Build();

// Public endpoint: no authentication required.
app.MapHealthChecks("/health").AllowAnonymous();

app.Run();
