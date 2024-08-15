namespace FactoryMethod
{
    public class RJPizzaCalabresa : Pizza
    {
        public RJPizzaCalabresa()
        {
            Nome = "Pizza de calabresa Carioca com cebola";
            massa = "Massa tradicional carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Fatias de calabresa especial");
            ingredientes.Add("Queijo parmessão italiano tradicional");
        }
    }
}
