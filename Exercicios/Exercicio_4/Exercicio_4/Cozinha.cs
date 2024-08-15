namespace Exercicio_4
{
    public class Cozinha
    {
        public void MontaLanche(CriadorLanche criadorLanche)
        {
            criadorLanche.AddPao();
            criadorLanche.AddRecheio();
            criadorLanche.AddVegetais();
            criadorLanche.AddCondimentos();
        }
    }
}
