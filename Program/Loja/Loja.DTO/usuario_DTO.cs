using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DTO
{
    class usuario_DTO
    {
        public int idUser { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime register { get; set; }
        public string situation { get; set; }
        public int perfil { get; set; }
    }
}
