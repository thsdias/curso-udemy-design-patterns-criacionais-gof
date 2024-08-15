namespace FactoryMethod2
{
    //ConcreteProduct
    public class PizzaCalabresa : Pizza
    {
        private readonly string _nomePizza;
        
        public PizzaCalabresa()
        {
            _nomePizza = "Pizza Calabresa";
            Ingredientes.Add("Fatias de calabresa especial");
            Ingredientes.Add("Queijo parmessão italiano tradicional");
        }

        public override string Nome { get => _nomePizza; }
    }
}
