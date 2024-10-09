using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.model
{
    internal class ProdutoDAO
    {
        private connection Con {  get; set; }
        private SqlCommand Cmd { get; set; }

        public ProdutoDAO()
        {
            Con = new connection();
            Cmd = new SqlCommand();
        }
        public void Insert(Produto produto)
        {
            Cmd.Connection = Con.ReturnConnect();
            Cmd.CommandText = @"INSERT INTO Produto VALUES (@Id,@NomeProduto, @Preco, @Quantidade)";

            Cmd.Parameters.AddWithValue("@Id", produto.Id);
            Cmd.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
            Cmd.Parameters.AddWithValue("@Preco", produto.preco);
            Cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);

            try
            {
                Cmd.ExecuteNonQuery(); 
            } 
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir Produto.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnect();
            }
        }
    }
}
