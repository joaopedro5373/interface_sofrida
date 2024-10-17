using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coisa_Boa
{
    public class Venda
    {
        public int id;
        [DisplayName("Id do Produto")] public int idProduto { get; set; }
        [DisplayName("Id do Cliente")] public int idCliente { get; set; }
        [DisplayName("Quantidade a ser vendida")] public int quantidade { get; set; }
        [DisplayName("Porcentagem de desconto")] public float desconto { get; set; }
    }
}
