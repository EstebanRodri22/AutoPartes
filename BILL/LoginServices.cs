using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BILL
{
    public class LoginServices
    {
        LoginRepository loginRepository = new LoginRepository();
        public bool loginUser(string username, string password)
        {
            return loginRepository.Login(username, password);
        }
    }
}
