using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio10
{
    public class VooGrupo : IReserva
    {
        public int dataReserva;
        public int dataVoo;
        public double valor;

        public void reservarVoo(){
            if (this.dataReserva != 0 && this.valor != 0) {
                Console.WriteLine("Voo reservado com sucesso!");
            } else {
                Console.WriteLine("Não foi possível reservar o voo!");
            }
        }


        public void cancelarReserva(){
            int difDatas = this.dataVoo - this.dataReserva;
            if (difDatas <= 2) {
                System.Console.WriteLine("Reserva cancelada com sucesso!");
            } else {
                System.Console.WriteLine("Prazo de cancelamento expirado! Por favor procure o guichê da companhia aérea.");
            }
        }

        public void verificaStatusReserva(){
            if (this.dataReserva != 0 && this.valor != 0) {
                System.Console.WriteLine("Voo reservado com sucesso!");
            } else {
                System.Console.WriteLine("Voô não reservado!");
            }
        }
    }
}