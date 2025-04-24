
using System.Threading.Channels;

public class Lancamento
    {
        public string Debito_Credito;
        public int Valor;
        public int Historico;
        public string Complemento;

    public void ExibirLancamento()
    {
        Console.WriteLine($"{Debito_Credito} {Valor} {Complemento}");
    }

    }
