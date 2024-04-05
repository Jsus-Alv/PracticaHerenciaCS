/*
El propósito de esta aplicación es ayudar a una compañía ficticia llamada Chimi MiBarriga del 
Sr. Billy Navaja, para administrar sus procesos de venta de hamburguesas (chimichurri).
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Chimi de Billy \n");

        Console.WriteLine("Seleccione el tipo de hamburguesa que desee:\n1. Clasica\n2. Saludable\n3. Premium");

        int opcionBurger = int.Parse(Console.ReadLine());
        Burger burger;

        switch (opcionBurger)
        {
            case 1:
                burger = new HamburguesaClasica();
                break;
            case 2:
                burger = new HamburguesaSaludable();
                break;
            case 3:
                burger = new HamburguesaPremium();
                break;
            default:
                Console.WriteLine("Opción no válida. Se le ha seleccionado la hamburguesa clásica por defecto.");
                burger = new HamburguesaClasica();
                break;
        }

        Console.WriteLine("\nDesea agregar ingredientes adicionales? (Si/No)");
        string respuesta = Console.ReadLine();

        if (respuesta.ToLower() == "s" || respuesta.ToLower() == "si" || respuesta.ToLower() == "y" || respuesta.ToLower() == "yes")
        {
           List<string> ingredientesDisponibles = new List<string> { "Lechuga", "Tomate", "Cebolla", "Pepinillos", "Tocino", "Queso" };

            Console.WriteLine("\nIngredientes disponibles:");
            for (int i = 0; i < ingredientesDisponibles.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ingredientesDisponibles[i]}"); //Se usan los indices de la lista para no hacer el codigo mas largo 
            }

            int ingredientesMaximos = 4;

            if (burger is HamburguesaSaludable)
            {
                ingredientesMaximos = 6;
            }
            else if (burger is HamburguesaPremium)
            {
                Console.WriteLine("\nNo se pueden agregar ingredientes adicionales a una hamburguesa Premium.");
                burger.MostrarPrecio();
                Console.WriteLine("\nGracias por su compra. Que lo disfrute!");
                return;
            }

            string opcionIngrediente;
            int ingredientesAgregados = 0;

            for (int i = 0; i < ingredientesMaximos; i++)
            {
                Console.WriteLine($"\nIngrese el número del ingrediente adicional que desea agregar ({ingredientesMaximos - i} restantes, o escriba 'fin' para terminar):");
                opcionIngrediente = Console.ReadLine();
                if (opcionIngrediente.ToLower() == "fin")
                {
                    break;
                }
                int indiceIngrediente;
                if (int.TryParse(opcionIngrediente, out indiceIngrediente) && indiceIngrediente >= 1 && indiceIngrediente <= ingredientesDisponibles.Count)
                {
                    string ingredienteSeleccionado = ingredientesDisponibles[indiceIngrediente - 1];
                    burger.AgregarIngrediente(ingredienteSeleccionado);
                }
                else
                {
                    Console.WriteLine("Número de ingrediente no válido. Intente nuevamente.");
                    i--;
                }
            }

        }

        burger.MostrarPrecio();
        Console.WriteLine("\nGracias por su compra. Que lo disfrute!");
    }
}
