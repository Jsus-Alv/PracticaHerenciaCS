public class HamburguesaPremium : Burger
{
    public HamburguesaPremium()
    {
        Console.WriteLine("\nInformacion del combo:\n - Hamburguesa Clasica\n - Papas fritas\n - Soda");
        precioBase += 100;
    }

    public override void AgregarIngrediente(string ingrediente)
    {
        Console.WriteLine("No se pueden agregar más ingredientes a una hamburguesa Premium.");
    }

    
}