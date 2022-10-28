﻿using System;

namespace Facade_Exemplo.Subsistemas
{
    public class Cadin
    {
        public bool EstaNoCadin(Cliente cliente)
        {
            Console.WriteLine($"Verificando o CADIN para o cliente {cliente.Nome}");
            return false;
        }
    }
}
