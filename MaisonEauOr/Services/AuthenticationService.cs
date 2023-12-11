using MaisonEauOr.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Security.Claims;

namespace MaisonEauOr.Services;

public class AuthenticationService : AuthenticationStateProvider
{
    private readonly ProtectedSessionStorage _sessionStorage;
    private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());

    public AuthenticationService(ProtectedSessionStorage sessionStorage)
    {
        _sessionStorage = sessionStorage;
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        try
        {
            var userSessionStorage = await _sessionStorage.GetAsync<UserSession>("UserSession");
            var userSession = userSessionStorage.Success ? userSessionStorage.Value : null;

            if (userSession == null)
            {
                return await Task.FromResult(new AuthenticationState(_anonymous));
            }

            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userSession.Identifier.ToString()),
                new Claim(ClaimTypes.Name, userSession.UserName),
                new Claim(ClaimTypes.Role, userSession.Role.ToString())
            }, "AuthorizedAuth"));

            return await Task.FromResult(new AuthenticationState(claimsPrincipal));
        }
        catch (Exception)
        {
            return await Task.FromResult(new AuthenticationState(_anonymous));
        }
    }

    public async Task UpdateAuthentificationState(UserSession? userSession)
    {
        ClaimsPrincipal claimsPrincipal;

        if (userSession != null)
        {
            await _sessionStorage.SetAsync("UserSession", userSession);
            claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userSession.Identifier.ToString()),
                new Claim(ClaimTypes.Name, userSession.UserName),
                new Claim(ClaimTypes.Role, userSession.Role.ToString())
            }));
        }
        else
        {
            await _sessionStorage.DeleteAsync("UserSession");
            claimsPrincipal = _anonymous;
        }

        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
    }

    public async Task<UserSession?> GetCurrentUser()
    {
        var res = await _sessionStorage.GetAsync<UserSession>("UserSession");
        return res.Success ? res.Value : null;
    }
}