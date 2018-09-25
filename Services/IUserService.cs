using System.Collections.Generic;
using Admin_tools.Models;

namespace Admin_Tool
{
    public interface IUserService
    {
        AppUser Authenticate(string email, string password);
        AppUser Create(string email, string password,string telephone,string fullName);

        bool Save();
    }
}