
using System.Threading.Channels;

public class Lancamento
    {
        public string Debito_Credito {  get; set; }
        public int Valor {  get; set; }
        public int Historico { get; set; }
        public string Complemento { get; set; }
        public bool Conciliado { get; set; }

        public string Data { get; set; }

        public string DescricaoResumida =>  $"{Data} {Debito_Credito} {Historico} {Complemento} {Valor}";



    public void ExibirLancamento()
    {
        Console.WriteLine(DescricaoResumida);
    }

    }
