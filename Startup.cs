public void ConfigurationServices(IServiceCollection services)
{
    // (...codes)
    // The job of the ConfigureServices method is adding things to the service container, or the collection of services that ASP.NET Core knows about. The services.AddMvc line adds the services that the internal ASP.NET Core systems need

    services.AddSingleton<ITodoItemService, FakeTodoItemService>();

    // This line tells ASP.NET Core to use the  FakeTodoItemService whenever the ITodoItemService interface is requested in a constructor or (anywhere else)
    // AddSingleton adds your service to the service container as a singleton

    services.AddMvc();
}