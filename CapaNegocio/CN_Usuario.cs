using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {

        private CD_usuario objcd_usuario = new CD_usuario();

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

    }
}
