# Hilos (ALUMNOS: BENNER ALAN, MALDONADO MATEO, ZARATE SEBASTIÁN)
En un sistema, los procesos que se ejecutan de forma concurrente pueden ser clasificados como independientes o cooperantes. Los procesos independientes operan de manera autónoma, sin depender de otros procesos. Por ejemplo, los intérpretes de comandos en un sistema funcionan de forma independiente. Por otro lado, los procesos cooperantes están diseñados para trabajar juntos en una actividad, requiriendo comunicación e interacción entre sí.

Tanto los procesos independientes como los cooperantes pueden interactuar de dos formas distintas:

- Interacciones motivadas por el **acceso a recursos compartidos**. Esto ocurre cuando los procesos compiten o comparten recursos físicos o lógicos. Por ejemplo, dos procesos independientes pueden competir por acceder a un disco o modificar el contenido de un registro en una base de datos. El sistema operativo debe gestionar estos accesos para evitar conflictos.

- Interacciones motivadas por la **comunicación y sincronización entre procesos** para lograr un objetivo común. Por ejemplo, un compilador se puede construir utilizando dos procesos: uno que genera código ensamblador y otro que convierte ese código en lenguaje máquina. En este caso, es necesario que ambos procesos se comuniquen y sincronicen para lograr una compilación exitosa.

Estas interacciones entre procesos requieren que el sistema operativo proporcione mecanismos y servicios para facilitar la comunicación y sincronización entre ellos.

## Enunciado

1- Supongamos que estás desarrollando un sistema de gestión de inventario para una tienda. Tienes una lista de productos y tres tareas que deben realizarse de manera concurrente:
- **Tarea 1 - Actualizar el stock**: Esta tarea consiste en recorrer la lista de productos y actualizar la cantidad en stock de cada uno. Para simplificar, consideremos que la tarea consiste en aumentar en 10 unidades la cantidad en stock de cada producto.
- **Tarea 2 - Actualizar el precio del dólar**: Esta tarea consiste en actualizar el precio actual del dólar para que posteriormente los informes tengan un precio real. Los precios registrados en el sistema están todos en dólares. 
- **Tarea 3 - Generar informe**: Esta tarea depende de las dos tareas anteriores. Debe generar un informe que muestre la lista de productos junto con su cantidad en stock actualizada y el precio total del inventario.
El objetivo es crear un programa en C# utilizando hilos que realice estas tres tareas de manera concurrente. Cada tarea debe ejecutarse en un hilo separado. Asegúrate de utilizar los mecanismos de sincronización adecuados para asegurar que la tarea 3 no comience hasta que las tareas 1 y 2 hayan finalizado correctamente. 

2- Supongamos que el sistema de gestión de inventario de la tienda ha evolucionado y ahora se requiere agregar una nueva tarea: la actualización de precios de los productos. Esta tarea consiste en recorrer la lista de productos y ajustar los precios según una nueva política de precios establecida por la gerencia (+10% por inflación) antes de generar los informes. 
El nuevo objetivo es modificar el programa del punto anterior para que el informe pueda generarse de manera correcta, con el stock y el precio actualizado. Ten en cuenta que varias tareas comparten la misma lista de productos.  

### *Aclaraciones*
En el proyecto dentro de este repositorio, encontrarán todas las herramientas para poder resolver este enunciado.
Para entregar el proyecto debe forkear este repositorio, resolver los enunciados y hacer una pull request con la solución para que se considere entregado. 
