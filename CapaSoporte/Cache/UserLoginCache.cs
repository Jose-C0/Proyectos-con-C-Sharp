using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSoporte.Cache
{
    public static class UserLoginCache
    {
        public static int Id { get; set; }
        public static int IdRol { get; set; }

        public static string Nombre   { get; set; }
        public static string Apellido { get; set; }
        public static string Telefono { get; set; }
        public static string Correo   { get; set; }
        public static string Descripcion { get; set; }


    }
}
