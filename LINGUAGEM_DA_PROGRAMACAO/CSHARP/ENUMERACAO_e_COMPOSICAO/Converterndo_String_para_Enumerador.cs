
/* CONVERTENDO STRING PARA ENUMERAÇÃO */

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

OU

OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

OU

OrderStatus os;
Enum.TryParse("Delivered", out os);