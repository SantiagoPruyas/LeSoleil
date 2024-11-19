using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Auditoria
    {
        private CD_Auditoria objcd_auditoria = new CD_Auditoria();

        public List<Auditoria> Listar()
        {
            return objcd_auditoria.Listar();
        }

        public bool Registrar(int id, out string Mensaje)
        {
            return objcd_auditoria.Registrar(id, out Mensaje);
        }
    }
}
