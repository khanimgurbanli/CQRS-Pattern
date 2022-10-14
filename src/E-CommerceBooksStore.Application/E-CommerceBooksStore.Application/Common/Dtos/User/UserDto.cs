using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceBooksStore.Application.Common.Dtos.User
{
    public class UserDto
    {
        public string UserName { get; set; } = null!;
        public string? Email { get; set; }
    }
}
