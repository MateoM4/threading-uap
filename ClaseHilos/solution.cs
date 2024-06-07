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

      static Barrier barrier = new Barrier(3, (b) =>
      {
          Console.WriteLine($"Post-Phase action: {b.CurrentPhaseNumber}");
      });

      static void Tarea1()
      {
        foreach(Producto p in productos)
        {
            Console.WriteLine($" (1a) Producto: {p.Nombre} - Stock: {p.CantidadEnStock}");
            p.CantidadEnStock += 10;
            Console.WriteLine($"(1b) Producto: {p.Nombre} - NUEVO Stock: {p.CantidadEnStock}");
        }
        barrier.SignalAndWait();


      }

      static void Tarea2()
      {    
        // el dolar toma un valor aleatorio entre 500 y 600  
        precio_dolar = new Random(precio_dolar).Next(500, 600);
        Console.WriteLine($"(2) Precio del dolar: {precio_dolar}");
        barrier.SignalAndWait();

      }

      static void Tarea3()
      {
        barrier.SignalAndWait();
         Console.WriteLine("<---------------- Informe de Productos ---------------->");
         foreach (Producto p in productos)
         {
            Console.WriteLine($"Producto: {p.Nombre}- Stock: {p.CantidadEnStock} - Precio en Pesos: {p.PrecioUnitarioDolares * precio_dolar}");
 
         }
      }

      internal static void Excecute()
      {

            Thread hilo1 = new Thread(new ThreadStart(Tarea1));
            Thread hilo2 = new Thread(new ThreadStart(Tarea2));
            Thread hilo3 = new Thread(new ThreadStart(Tarea3));

            hilo1.Start();
            hilo2.Start();
            hilo3.Start();
            /*
            tarea1.Start();
            tarea2.Start();
            Console.ReadLine();
            
            /*
            Tarea1();
            Tarea2();
            Tarea3();
            */


            Console.ReadLine();
        }
   }
}