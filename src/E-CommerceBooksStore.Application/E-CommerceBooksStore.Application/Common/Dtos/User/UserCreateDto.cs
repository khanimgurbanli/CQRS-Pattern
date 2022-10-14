using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceBooksStore.Application.Common.Dtos.User
{
    public class UserCreateDto
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
