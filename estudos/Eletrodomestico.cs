namespace estudos
{
    public abstract class Eletrodomestico : IProdutoEletrico
    {
        public virtual void Ligar()
        {
            Console.WriteLine("produto ligado");
        }
    }
}
