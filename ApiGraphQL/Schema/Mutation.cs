using ApiGraphQL.Entidade;

namespace ApiGraphQL.Schema
{
    public class Mutation
    {
        //public Mutation()
        //{

        //}
        public bool SalvarCliente(int id, string nome, string endereco)
        {
            List<Cliente> list = new List<Cliente>();
            Cliente cliente = new Cliente();
            cliente.Id = id;
            cliente.endereco = endereco;
            cliente.Nome = nome;
            list.Add(cliente);
            return true;
        }
    }
}
