while (true)
{
    Menu();
    string opcion = Console.ReadLine(); //Readline lee desde teclado

    switch (opcion)
    {
        case "0":
            return;
        case "1":
            Titulo("Tipos de datos");
            break;
        case "2":
            Titulo("POO - Estamos trabajando");
            break;
        case "3":
            Titulo("Arrays y matrices");
            ArrayMatriz.Run();
            break;
        default:
            Console.WriteLine("Opción invalida, pulse una tecla para continuar");
            break;
    }
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