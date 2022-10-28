using System;

namespace Facade_Exemplo.Subsistemas
{
    public class Cadastro
    {
        public void CadastrarCliente(Cliente cliente)
        {
            Console.WriteLine($"Cadastro do cliente {cliente.Nome} sem pendências");
        }
    }
}
