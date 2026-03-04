using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace capitulo04.Refatorando
{
    public interface IServicoDeEntrega
    {
        double para(string Cidade);
    }
}
