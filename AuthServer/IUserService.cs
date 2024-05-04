﻿namespace AuthServer
{
    public interface IUserService
    {
        Task<User> GetUserAsync(string username);
        Task<bool> CreateUserAsync(User user);
        
    }
}
