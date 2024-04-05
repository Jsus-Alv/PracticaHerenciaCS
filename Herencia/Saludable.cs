public class HamburguesaSaludable : Burger
{
    public HamburguesaSaludable()
    {
        tipoPan = "Pan Integral";
        precioBase += 30;
    }

    public override void MostrarPrecio()
    {
        if (ingredientesExtras.Count > 0)
        {
            Console.WriteLine("\nInformacion de compra: ");
            Console.WriteLine($"\nTipo de pan: {tipoPan}");
            Console.WriteLine("\nIngredientes adicionales:");
            foreach (string ingrediente in ingredientesExtras)
            {
                Console.WriteLine($"- {ingrediente} +15 pesos");
            }
        }

        Console.WriteLine($"\nPrecio total: {precioBase} pesos");
    }

    public override void AgregarIngrediente(string ingrediente)
    {
        if (ingredientesExtras.Count < 6)
        {
            ingredientesExtras.Add(ingrediente);
            precioBase += 15;
            Console.WriteLine($"{ingrediente} adicional agregado. Nuevo precio: {precioBase} pesos.");
        }
        else
        {
            Console.WriteLine("No se pueden agregar más ingredientes a esta hamburguesa.");
        }
    }

}