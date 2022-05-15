using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleEstoque.Entites;
using ControleEstoque.Entites.Enums;

namespace ControleEstoque.Entites
{
    public class Order
    {
        public int Id { get; set; }
        
        public DateTime Moment { get; set; }
        
        public OrderStatus CodStatus { get; set; }

        public override string ToString()
        {
            return Id + ", \n" + Moment + ", \n" + CodStatus;
        }
    }
}