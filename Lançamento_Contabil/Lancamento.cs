
using System.Threading.Channels;

public class Lancamento
    {
        public string Debito_Credito;
        public int Valor;
        public int Historico;
        public string Complemento;
        private bool conciliado;


    public void escreveconcilado(bool value)
    {
        conciliado = value;
    }

    public bool Leconciliado()
    {
        return conciliado;
    }

    public void ExibirLancamento()
    {
        Console.WriteLine($"{Debito_Credito} {Valor} {Complemento}");
    }

    }
