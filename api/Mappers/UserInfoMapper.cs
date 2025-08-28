using api.Dtos.Account;
using api.Models;
using Azure.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;

namespace api.Mappers
{
    public static class UserInfoMapper
    {
        public static AllUserInfoDto UsertoAllUserDto(this AppUser appUser)
        {
            return new AllUserInfoDto
            {
                Id = appUser.Id,
                userName = appUser.UserName,
                email = appUser.Email
            };
        }
    }
}
