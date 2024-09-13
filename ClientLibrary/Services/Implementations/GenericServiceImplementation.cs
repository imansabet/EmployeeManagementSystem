using BaseLibrary.Responses;
using ClientLibrary.Helpers;
using ClientLibrary.Services.Contracts;
using System.Net.Http;
using System.Net.Http.Json;

namespace ClientLibrary.Services.Implementations;

public class GenericServiceImplementation<T>(GetHttpClient getHttpClient) : IGenericServiceInterface<T>
{
    //Create
    public async Task<GeneralResponse> Insert(T item, string baseUrl)
    {
        var httpClient = await getHttpClient.GetPrivateHttpClient();
        var response = await httpClient.PostAsJsonAsync($"{baseUrl}/add", item);
        var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
        return result!;
    }
    //Read all
    public async Task<List<T>> GetAll(string baseUrl)
    {
        var httpClient = await getHttpClient.GetPrivateHttpClient();
        var results =  await httpClient.GetFromJsonAsync<List<T>>($"{baseUrl}/all");
        return results!;
    }
    //Read single by id
    public async Task<T> GetById(int id, string baseUrl)
    {
        var httpClient = await getHttpClient.GetPrivateHttpClient();
        var results = await httpClient.GetFromJsonAsync<T>($"{baseUrl}/single/{id}");
        return results!;

    }
    //delete by id
    public async Task<GeneralResponse> DeleteById(int id, string baseUrl)
    {
        var httpClient = await getHttpClient.GetPrivateHttpClient();
        var response = await httpClient.DeleteAsync($"{baseUrl}/delete/{id}");
        var results = await response.Content.ReadFromJsonAsync<GeneralResponse>();
        return results!;
    }
    //update{model}
    public async Task<GeneralResponse> Update(T item, string baseUrl)
    {
        var httpClient = await getHttpClient.GetPrivateHttpClient();
        var response = await httpClient.PostAsJsonAsync($"{baseUrl}/update", item);
         var results =   await response.Content.ReadFromJsonAsync<GeneralResponse>();
        return results!;

    }
}
