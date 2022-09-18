using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authorization.Models;

namespace Authorization.Provider
{
    public interface IAuthProvider
    {
        public string AuthenticateUser(User user);
    }
}
