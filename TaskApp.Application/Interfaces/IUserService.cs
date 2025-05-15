using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Application.DTOs;

namespace TaskApp.Application.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetAll();
        UserDto GetById(Guid id);
        Guid Create(CreateUserDto dto);
        void Delete (Guid id);
        AuthResponseDto Register(RegisterDto dto);
        AuthResponseDto Login(LoginDto dto);
    }
}
