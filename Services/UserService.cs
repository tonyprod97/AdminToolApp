using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Admin_Tool.Helpers;
using Admin_Tool.Models;
using Admin_tools.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Admin_Tool.Services
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
        private readonly AdminToolContext _context;

        public UserService(IOptions<AppSettings> appSettings, AdminToolContext context)
        {
            _appSettings = appSettings.Value;
            _context = context;
        }

        public AppUser Authenticate(string email, string password)
        {
            var user = _context.AppUser.FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            // remove password before returning
            user.Password = null;

            return user;
        }

        public AppUser Create(string email, string password, string telephone, string fullName)
        {
            var newUser = _context.AppUser.FirstOrDefault(user=> user.Email == email);

            if(newUser != null) return null;
            newUser = new AppUser() {
                Email = email,
                Password = password,
                Telephone = telephone,
                FullName = fullName
            };
            _context.AppUser.Add(newUser);

            return newUser;
        }

        public bool Save()
        {
            return _context.SaveChanges()>-1;
        }

    }
}