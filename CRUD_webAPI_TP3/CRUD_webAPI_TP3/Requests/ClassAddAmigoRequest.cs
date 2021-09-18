using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_webAPI_TP3.Requests
{
    public class ClassAddAmigoRequest
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public DateTime Aniversario { get; set; }
    }
}
