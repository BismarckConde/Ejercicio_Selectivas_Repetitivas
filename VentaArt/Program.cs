string Codigo;
int Cantidad;
double Costo;
double PagoTotal;

Console.WriteLine(" *** BIENVENIDO AL SISTEMA DE COMPRAS *** ");

Console.WriteLine(" POR FAVOR INGRESE EL CODIGO DE BARRA DEL ARTICULO ");
Codigo = Console.ReadLine();

Console.WriteLine(" INGRESE LA CANTIDAD DE ARTICULOS ");
Cantidad = int.Parse(Console.ReadLine());

if (Cantidad ==4)
{
    Cantidad = 3;
    Console.WriteLine(" ¡ ESTAS DE SUERTE!... SOLO SE TE COBRARAN UNICAMENTE 3 ARTICULOS ");

}
Console.WriteLine(" INGRESA EL COSTO DEL ARTICULO ");
Costo = Convert.ToDouble(Console.ReadLine());

PagoTotal = Cantidad * Costo;
if (PagoTotal > 300)
{
    int vales = (int)(PagoTotal / 100) * 10;
    Console.WriteLine(" POR CADA 100 PESOS DE COMPRAS SE TE OBSEQUIARAN "+vales+" PESOS EN VALES  ");
}
Console.WriteLine(" EL TOTAL A PAGAR ES : "+PagoTotal);
Console.WriteLine(" FIN DEL PROGRAMA");
Console.ReadKey();


