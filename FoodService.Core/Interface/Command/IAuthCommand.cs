﻿using FoodService.Core.Dto;
using FoodService.Nuget.Models;
using FoodService.Nuget.Models.Auth.User;

namespace FoodService.Core.Interface.Command
{
    public interface IAuthCommand
    {
        Task<ResponseCommon<bool>> AddUserToAdminRole(int userId);
        Task<ResponseCommon<UserBase>> GetCurrentUser();
        Task<ResponseCommon<UserDto>> GetUserDto(int id);
        Task<ResponseCommon<List<ClientUser>>> ListUsers();
        Task<ResponseCommon<SsoDto>> SignIn(SignInDto signInDTO);
        Task<ResponseCommon<bool>> SignUp(SignUpDto signUpDto);
    }
}