using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coisa_Boa
{
    public class Compra
    {
        public int id;
        [DisplayName("Id do produto")] public int idProduto { get; set; }
        [DisplayName("Id do fornecedor")] public int idFornecedor { get; set; }
        [DisplayName("Quantidade Comprada")] public int quantidade { get; set; }
        [DisplayName("Porcentagem de desconto")] public float desconto { get; set; }
    }
}
