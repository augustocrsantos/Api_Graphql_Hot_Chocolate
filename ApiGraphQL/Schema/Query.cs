using ApiGraphQL.Entidade;

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

        public string teste => "Augusto Teste ";
    }
}
