using CurrencyRateAnalyzer.Application.Commands.Identity;
using CurrencyRateAnalyzer.Application.Dtos;
using CurrencyRateAnalyzer.Domain.Entities.Identity;
using Microsoft.IdentityModel.JsonWebTokens;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRateAnalyzer.Application.Interfaces.Services.Identity
{
    public interface IIdentityService
    {
        Task<UserDto> GetAsync(Guid id);
        Task<AuthDto> SignInAsync(SignInCommand command);
        Task SignUpAsync(SignUpCommand command);
        Task ChangePasswordAsync(Guid userId, string currentPassword, string newPassword);
    }
}
