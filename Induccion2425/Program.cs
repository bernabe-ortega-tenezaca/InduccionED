while (true)
{
    string opcion = Console.ReadLine(); //Readline lee desde teclado
}


// Encabezado();
// Menu();
// Pie();

/// ZONA DE FUNCIONES
static void Menu(){ // Funcion que se actualiza cada semana
    Console.WriteLine("Por favor seleccione una opción:");
    Console.WriteLine("1 - Tipos de datos");
    Console.WriteLine("2 - POO con encapsulamiento");
    Console.WriteLine("3 - Matrices");
    Console.WriteLine("4 - Registros y Structs");
    //Console.WriteLine("5 - ...................");
    Console.WriteLine("----------------------");
    Console.WriteLine("0 - Salir");
}

/// Imprime en pantalla un texto
static void Titulo(string titulo){ // función con un parámetro
    Console.WriteLine(titulo);
}

/// Función para el encabezado del proyecto
static void Encabezado(){ // función sin parámetros
    Console.WriteLine("  UNIVERSIDAD ESTATAL AMAZÓNICA");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("");
}

// Función para el pie de página del proyecto
static void Pie(){
    Console.WriteLine();
    Console.WriteLine("--------------------------------");
    Console.WriteLine("Desarrollado por @Bernabé Ortega");
}