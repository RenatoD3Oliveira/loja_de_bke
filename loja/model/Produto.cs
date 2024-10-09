using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.model
{
    internal class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set;}
        public float preco { get; set;}
        public int Quantidade { get; set;}
    }
}
