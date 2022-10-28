using System;

namespace Facade_Exemplo.Subsistemas
{
    public class Serasa
    {
        public bool EstaNoSerasa(Cliente cliente)
        {
            Console.WriteLine("Verificando SERASA do cliente " + cliente.Nome);
            return false;
        }
    }
}
