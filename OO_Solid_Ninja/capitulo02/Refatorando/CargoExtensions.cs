using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo02.Refatorando
{
    public static class CargoExtensions
    {
        public static IRegraDeCalculo GetRegra(this Cargo2 cargo)
        {
            return cargo switch
            {
                Cargo2.Desenvolvedor => new dezOuVintePorCento( ),
                Cargo2.DBA => new quinzeOuVintePorCentro(),
                Cargo2.Testador => new quinzeOuVintePorCentro(),
                _ => throw new ArgumentException("Cargo inválido")
            };
        }
    }
}
