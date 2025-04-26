class Razao
{
    private List<Lancamento> lancamentos = new List<Lancamento>();
    public int RazaoConta { get; set; }
    public int TotalConta { get; set; }

    public void AdicionarLancamento (Lancamento lancamento)
    {
        lancamentos.Add(lancamento);
    }

    public void ExibirLancamento()
    {
        Console.WriteLine($"Razao da conta {RazaoConta}\n");
        foreach (var lancamento in lancamentos)
        {
            Console.WriteLine($"{lancamento.DescricaoResumida}\n");
        }
    }

}