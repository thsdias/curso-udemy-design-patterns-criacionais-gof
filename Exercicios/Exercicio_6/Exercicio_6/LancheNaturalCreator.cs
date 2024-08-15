namespace Exercicio_6
{
    public class LancheNaturalCreator : LancheCreator
    {
        protected override Lanche CriaLanche()
        {
            return new LancheNatural();
        }
    }
}
