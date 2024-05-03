using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio10
{
    public interface IReserva
    {
        public void reservarVoo();
        public void cancelarReserva();
        public void verificaStatusReserva();
    }
}