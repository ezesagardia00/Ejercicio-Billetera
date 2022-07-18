using Billetera;

var b1 = new Billetera.Billetera();
var b2 = new Billetera.Billetera();

b1.BilletesDe100 = 1;

b2.BilletesDe1000 = 1;

Console.WriteLine(b1.Total.ToString());
Console.WriteLine(b2.Total.ToString());

var b3 = b1.Combinar(b2);

Console.WriteLine(b3.Total.ToString());


