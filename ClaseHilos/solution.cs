namespace ClaseHilos
{
   internal class Producto
   {
      public string Nombre { get; set; }
      public decimal PrecioUnitarioDolares { get; set; }
      public int CantidadEnStock { get; set; }

      public Producto(string nombre, decimal precioUnitario, int cantidadEnStock)
      {
         Nombre = nombre;
         PrecioUnitarioDolares = precioUnitario;
         CantidadEnStock = cantidadEnStock;
      }
   }
   internal class Solution //reference: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/lock
   {

      static List<Producto> productos = new List<Producto>
        {
            new Producto("Camisa", 10, 50),
            new Producto("Pantalón", 8, 30),
            new Producto("Zapatilla/Champión", 7, 20),
            new Producto("Campera", 25, 100),
            new Producto("Gorra", 16, 10)
        };

      static int precio_dolar = 500;

      static void Tarea1(List<Producto> productos)
      {
         foreach(Producto p in productos)
         {
            Console.WriteLine($"Producto: {p.Nombre} - Stock: {p.CantidadEnStock}");
            p.CantidadEnStock += 10;
            Console.WriteLine($"Producto: {p.Nombre} - NUEVO Stock: {p.CantidadEnStock}");
            }

         
      }
      static void Tarea2(List<Producto> productos)
      {
         foreach (Producto p in productos)
            {
                Console.WriteLine($"Producto: {p.Nombre} - Precio USD: {p.PrecioUnitarioDolares}");
                p.PrecioUnitarioDolares *= precio_dolar;
                Console.WriteLine($"Producto: {p.Nombre} - Precio Pesos: {p.PrecioUnitarioDolares}");
            }
        }
      static void Tarea3()
      {
         throw new NotImplementedException();
      }

      internal static void Excecute()
      {
            Tarea1(productos);
            Console.ReadLine();
            Tarea2(productos);
            Console.ReadLine();
        }
   }
}