using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authorization.Models;

namespace Authorization.Repository
{
    public interface IAuthRepository
    {
        public string GenerateToken(User user);
    }
}
