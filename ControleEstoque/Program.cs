using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleEstoque.Entites;
using ControleEstoque.Entites.Enums;

Order order = new Order {
    Id = 1080,
    Moment = DateTime.Now,
    CodStatus = OrderStatus.PendingPayment
};

string txt = OrderStatus.PendingPayment.ToString();

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(order);
Console.WriteLine(txt);
Console.WriteLine(os);
Console.ReadKey();