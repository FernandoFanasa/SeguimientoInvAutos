
using SeguimientoInvAutos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoInvAutos.Services
{
    interface ILoginRepositoty  
    {
        Task<UserInfo> Login(string UserName, string Password);
    }
}
