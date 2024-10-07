using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Perfil
    {
        private CD_Perfil objcd_perfil = new CD_Perfil();

        public List<Perfil> Listar()
        {
            return objcd_perfil.Listar();
        }
    }
}
