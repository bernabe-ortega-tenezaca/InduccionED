using System.Diagnostics;
using System.Numerics;

public static class ArrayMatriz{
    public static void Run(){
        int[] numeros = new int[10]; // definición de un array(vector) llamado números
        numeros[0] = 12;        numeros[1] = 1;
        numeros[2] = 2;         numeros[3] = 21;
        numeros[4] = 22;        numeros[5] = 31;
        numeros[6] = 412;        numeros[7] = 512;
        numeros[8] = 612;        numeros[9] = 712;
        Console.WriteLine("La novena posición del vector es: " + numeros[8]);
        Console.WriteLine("La segunda posición del vector es {0}, y la tercera es: {1}", numeros[1], numeros[2]);
        Console.WriteLine($"La segunda posición del vector es {numeros[1]}, y la tercera es: {numeros[2]}");
        Console.WriteLine("La longitud del vector números es: " + numeros.Length);

        Producto[] productos = new Producto[20]; //Creamos un array de 20 productos

        Producto miproducto = new Producto(1, "cuderno", "docenas");
        productos[0] = miproducto;
        Console.WriteLine("El producto es : {0} y {1}",productos[0].Nombre, productos[0].Unidad);
    }
}