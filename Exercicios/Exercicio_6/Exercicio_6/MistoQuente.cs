namespace Exercicio_6
{
    public class MistoQuente : Lanche
    {
        public override string GetPao()
        {
            return "Pão de forma branco";
        }

        public override string GetRecheio()
        {
            return "100g de Presunto e 100g de queijo ";
        }
        
        public override string GetCondimentos()
        {
            return "50g de Tomate";
        }
    }
}
