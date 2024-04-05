public class Burger
{
    public string tipoPan;
    public bool carne;
    public List<string> ingredientesExtras; // Cada ingrediente adicional le añadira 15 pesos a la hamburguesa
    public double precioBase;

    public Burger()
    {
        tipoPan = "Pan Blanco";
        carne = true;
        ingredientesExtras = new List<string>();
        precioBase = 200;
    }

    public virtual void AgregarIngrediente(string ingrediente)
    {
        if (ingredientesExtras.Count < 4)
        {
            ingredientesExtras.Add(ingrediente);
            precioBase += 15;
            Console.WriteLine($"{ingrediente} adicional agregado. Nuevo precio: {precioBase} pesos.");
        }
        else
        {
            Console.WriteLine("No se pueden agregar ma ingredientes a esta hamburguesa");
        }
    }

    public virtual void MostrarPrecio()
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
}

