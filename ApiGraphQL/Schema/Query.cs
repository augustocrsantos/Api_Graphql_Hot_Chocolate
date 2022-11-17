using ApiGraphQL.Entidade;
using projeto;

namespace ApiGraphQL.Schema
{
    public class Query
    {
        public IEnumerable<Cliente> GetCliente()
        {
            return new List<Cliente>()
            {
                new Cliente
                {
                    endereco = "rua Itaperuna",
                    Id= 1,  
                    Nome = "augusto"
                }       
                
            };
        }


        public Cliente RetornaCliente()
        {
            Cliente cliente= new Cliente();
            cliente.Id = 1; 
            cliente.Nome = "augusto";
            cliente.endereco = "icaraí";

            return cliente;
        }

        public Pessoa RetornaPessoa()
        {
            Pessoa pessoa= new Pessoa();
            pessoa.nome = "augusto";
            pessoa.cidade = "Divinopolis";
            return pessoa;  


        }

        public string teste => "Augusto Teste ";
    }
}
