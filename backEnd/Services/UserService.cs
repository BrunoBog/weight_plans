using System.Threading.Tasks;
using backEnd.model;
using Microsoft.AspNetCore.Mvc;

namespace backEnd.Services
{
    public class UserService
    {
        public UserService(UserRepository UserRepository)
        {
            this.UserRepository = UserRepository;
        }

        public UserRepository UserRepository { get; }

        public async Task<dynamic> Authenticate(User model)
        {
            var user = await UserRepository.GetByEmailAndPasswordAsync(model.Email, model.Password);

            if (user == null) return user;

            var token = TokenService.GenerateToken(user);
            user.Password = "";
            return new
            {
                user = user.Email,
                token
            };
        }

        internal async Task<User> SignUpAsync(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password)  ) return null;
            if (string.IsNullOrWhiteSpace(user.Role)) user.Role = RolaesEnum.User.ToString();
            var newUser = await UserRepository.CreateAsync(user);
            var login = await Authenticate(newUser);
            newUser.Token = login.token;
           return newUser;
        }
    }
}