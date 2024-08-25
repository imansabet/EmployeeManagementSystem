using BaseLibrary.DTOs;
using BaseLibrary.Responses;
using ClientLibrary.Services.Contracts;

namespace ClientLibrary.Services.Implementations;

public class UserAccountService : IUserAccountService
{
    public Task<GeneralResponse> CreateAsync(Register user)
    {

    }

    public Task<LoginResponse> RefreshTokenAsync(RefreshToken token)
    {

    }

    public Task<LoginResponse> SignInAsync(Login user)
    {

    }
}
