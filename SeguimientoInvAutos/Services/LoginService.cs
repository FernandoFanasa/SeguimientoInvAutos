using SeguimientoInvAutos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoInvAutos.Services
{
    public class LoginService : ILoginRepositoty
    {
        public Task<UserInfo> Login(string UserName, string Password)
        {
            throw new NotImplementedException();

            //aqui se hara la conexion a la API IDAAF
            //try 
            //{
                
            //}
            //catch 
            //{
            
            //}
            //return Login(UserName, Password);
        }
    }
}
