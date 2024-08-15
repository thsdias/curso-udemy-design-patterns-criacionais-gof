namespace Exercicio_6
{
    public class MistoQuenteCreator : LancheCreator
    {
        protected override Lanche CriaLanche()
        {
            return new MistoQuente();
        }
    }
}
