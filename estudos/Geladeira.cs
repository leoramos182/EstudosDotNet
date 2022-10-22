namespace estudos
{
    public class Geladeira : Eletrodomestico
    {
        public int Porta;

        public override void Ligar()
        {
            System.Console.WriteLine("Geladeira ligada");
        }

    }
}
