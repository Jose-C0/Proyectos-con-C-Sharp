using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CapaSoporte.Cache;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string Usuario, string Contrasena)
        {
            return userDao.Login(Usuario, Contrasena);
        }
        //public bool editPassword(int Usuario, string Contrasena)
        //{
        //    if (Usuario == UserLoginCache.Id)
        //    {

        //    }

        //    return true;
        //}
    }
}
