using Finzo.Data;
using Finzo.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Finzo.Repository
{
    public class UserRepository
    {
        private readonly DbContextFinzo _DBFinzo;


        public UserRepository(DbContextFinzo DBFinzo)
        {
            _DBFinzo = DBFinzo;
        }


        public void addUser(Users user)
        {
            _DBFinzo.Users.Add(user);
            _DBFinzo.SaveChanges();
        }


        public async Task<LoginResult> validateLogin(Users user)
        {
            if (!await _DBFinzo.Users.AnyAsync(u => u.Username == user.Username && u.Password == user.Password))
            {
                if (await _DBFinzo.Users.AnyAsync(u => u.Username == user.Username))
                    return new LoginResult(false, LoginStatus.IncorrectPassword);

                return new LoginResult(false, LoginStatus.UserNotFound);
            }
            else
            {
                return new LoginResult(true, LoginStatus.Success);
            }
        }      
    }
}
