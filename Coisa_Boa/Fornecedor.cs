using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coisa_Boa
{
    public class Fornecedor
    {
        [DisplayName("Id")] public int Id { get; set; }
        [DisplayName("Nome do fornecedor")] public string nome { get; set; }
        [DisplayName("Número de telefone")] public string telefone { get; set; }
        [DisplayName("Endereço de E-mail")] public string email { get; set; }
        [DisplayName("Endereço físico")] public string endereco { get; set; }

    }
}
