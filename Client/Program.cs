using BaseLibrary.Entities;
using Blazored.LocalStorage;
using Client;
using Client.ApplicationStates;
using ClientLibrary.Helpers;
using ClientLibrary.Services.Contracts;
using ClientLibrary.Services.Implementations;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Popups;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient<CustomHttpHandler>();

builder.Services.AddHttpClient("SystemApiClient" , client =>
{
    client.BaseAddress = new Uri("https://localhost:7041/");
}).AddHttpMessageHandler<CustomHttpHandler>();

builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<GetHttpClient>();
builder.Services.AddScoped<LocalStorageService>();
builder.Services.AddScoped<AuthenticationStateProvider,CustomAuthenticationStateProvider>();
builder.Services.AddScoped<IUserAccountService, UserAccountService>();
builder.Services.AddScoped<AllState>();

// dep
builder.Services.AddScoped<IGenericServiceInterface<GeneralDepartment>,GenericServiceImplementation<GeneralDepartment>>();
builder.Services.AddScoped<IGenericServiceInterface<Department>,GenericServiceImplementation<Department>>();
builder.Services.AddScoped<IGenericServiceInterface<Branch>,GenericServiceImplementation<Branch>>();
// c c t
builder.Services.AddScoped<IGenericServiceInterface<Country>,GenericServiceImplementation<Country>>();
builder.Services.AddScoped<IGenericServiceInterface<City>,GenericServiceImplementation<City>>();
builder.Services.AddScoped<IGenericServiceInterface<Town>,GenericServiceImplementation<Town>>();
//employee
builder.Services.AddScoped<IGenericServiceInterface<Employee>,GenericServiceImplementation<Employee>>();


Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NCaF1cWWhIfkx3QXxbf1x0ZFRMYFpbR3dPIiBoS35RckVqWHtfc3RTRWNeUUBz");

builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped<SfDialogService>();

await builder.Build().RunAsync();
