WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
Assembly assembly = Assembly.GetExecutingAssembly();
ConfigurationManager configuration = builder.Configuration;

builder.AddAppConfigurations();
builder.AddAutofacConfiguration();
builder.Host.UseSerilog((context, services, loggerConfiguration) =>
{
    MSerilogAction.Configure(context, services, loggerConfiguration, false);
});

Log.Information("Starting {ApplicationName} API up", builder.Environment.ApplicationName);

try
{
    IServiceCollection services = builder.Services;

    // Register services
    _ = services.AddApplication(assembly);
    _ = services.AddInfrastructure<Program>(configuration);
    _ = services.SwaggerConfig(builder.Environment.ApplicationName);
    _ = services.AddScopeServices(typeof(ApiDbContext).Assembly);
    _ = services.AddValidateBearerToken<MTokenInfo>(configuration);
    _ = services.AddDbContextConfigure<ApiDbContext>(configuration);
    _ = services.AddCors(configuration);

    WebApplication app = builder.Build();
    _ = app.UseCors("MAllowDomains");
    _ = app.UseDefaultMiddleware();
    _ = app.AddLocalization(assembly);
    _ = app.UseRouting();
    _ = app.UseAuthentication();
    _ = app.UseAuthorization();
    _ = app.ConfigureEndpoints();
    _ = app.MigrateDatabase<ApiDbContext>();

    await app.RunAsync();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Unhandled exception: {Message}", ex.Message);
}
finally
{
    Log.Information("Shut down {ApplicationName} complete", builder.Environment.ApplicationName);
    await Log.CloseAndFlushAsync();
}