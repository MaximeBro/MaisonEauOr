using MaisonEauOr.Databases;
using MaisonEauOr.Models;
using Microsoft.EntityFrameworkCore;

namespace MaisonEauOr.Services;

public class DoubleAuthService
{
	private IDbContextFactory<MeoDbContext> _factory = null!;

	public DoubleAuthService(IDbContextFactory<MeoDbContext> factory)
	{
		_factory = factory;
	}

	public async Task<bool> Check2ATokens(UserAccount user)
	{
		var context = await _factory.CreateDbContextAsync();
		var token = context.AuthTokens.Where(x => x.ClientID == user.Id).OrderByDescending(x => x.CreatedAt).FirstOrDefault();
		return token == null || HasTokenExpired(token);
	}

	public async Task<TokenStatus> Validate2ARequest(UserAccount user, string code)
	{
		var context = await _factory.CreateDbContextAsync();
		var token = context.AuthTokens.Where(x => x.ClientID == user.Id).OrderByDescending(x => x.CreatedAt).FirstOrDefault();
		if (token == null) return TokenStatus.Invalid;
		if (!HasTokenExpired(token))
		{
			if (token.Code == code)
			{
				return TokenStatus.Valid;
			}
		}
		else
		{
			return TokenStatus.Expired;
		}

		return TokenStatus.Invalid;
	}

	private bool HasTokenExpired(AuthTokenModel model)
	{
		return DateTime.Now - model.CreatedAt >= TimeSpan.FromMinutes(10);
	}
}

public enum TokenStatus
{
	Expired,
	Invalid,
	Valid
}