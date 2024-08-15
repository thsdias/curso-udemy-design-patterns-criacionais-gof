using System;

namespace SimpleFactory
{
    class PizzaSimpleFactory
    {
        public static Pizza CriaPizza(string nomePizza)
        {
            Pizza pizza;
            
            switch (nomePizza)
            {
                case "C":
                    pizza = new PizzaCalabresa();
                    break;
                case "M":
                    pizza = new PizzaMussarela();
                    break;
                default:
                    throw new ApplicationException($"A Pizza {nomePizza} não foi criada");
            }

            return pizza;
        }
    }
}
