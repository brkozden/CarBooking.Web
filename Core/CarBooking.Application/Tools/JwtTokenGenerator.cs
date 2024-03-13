using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CarBooking.Application.Dtos;

using CarBooking.Application.Features.Mediator.Results.AppUserResults;
using Microsoft.IdentityModel.Tokens;


namespace CarBooking.Application.Tools
{
	public class JwttokenGenerator
	{
		public static TokenResponseDto GenerateToken(CheckAppUserQueryResult result)
		{
			var claims = new List<Claim>();
			if (!string.IsNullOrWhiteSpace(result.Role))
			claims.Add(new Claim(ClaimTypes.Role,result.Role));
	        claims.Add(new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()));
			if (!string.IsNullOrWhiteSpace(result.Username))
				claims.Add(new Claim("Username", result.Username));

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key));

			var signingCredentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

			var expireDate = DateTimeOffset.UtcNow.AddDays(JwtTokenDefaults.Expire);

			JwtSecurityToken token = new JwtSecurityToken(issuer:JwtTokenDefaults.ValidIssuer,audience:JwtTokenDefaults.ValidAudience,claims:claims,notBefore:DateTime.UtcNow,expires:expireDate.Date,signingCredentials:signingCredentials);
			JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
			return new TokenResponseDto(tokenHandler.WriteToken(token), expireDate.Date);
		}
	}
}
