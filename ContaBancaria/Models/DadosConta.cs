using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaBancaria.Models
{
    public class DadosConta
    {
        public int cod_conta { get; set; }
        public string des_titular { get; set; }
        public string deposito { get; set; }
        public string opcao { get; set; }
        public decimal vlr_deposito { get; set; }
        public decimal vlr_saque { get; set; }
        public decimal vlr_saldo { get; set; }

        public void Depositar()
        {
            vlr_saldo = (vlr_saldo + vlr_deposito);
        }

        public void Sacar()
        {
            vlr_saldo = (vlr_saldo - vlr_saque - (decimal) 5.00);
        }
    }
}