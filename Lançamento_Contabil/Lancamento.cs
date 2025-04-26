
using System.Threading.Channels;

public class Lancamento
    {
        public string Debito_Credito {  get; set; }

        public int Conta { get; set; }

        public string ContaDescricao { get; set; }
        public int Valor {  get; set; }
        public int Historico { get; set; } // vincular uma lista ou um banco de dados de historicos que podem ser cadastrados pelo usuario
        public string Complemento { get; set; }
        public bool Conciliado { get; set; }

        public string Data { get; set; }

        public string DescricaoResumida =>  $"{Data} {Debito_Credito} Conta {Conta} {Historico} {Complemento} {Valor}";



    public void ExibirLancamento()
    {
        Console.WriteLine(DescricaoResumida);
    }

    }
