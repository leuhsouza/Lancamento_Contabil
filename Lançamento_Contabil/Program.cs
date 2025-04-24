
Lancamento lancamento1 = new Lancamento();
lancamento1.Debito_Credito = "D";
lancamento1.Valor = 150;
lancamento1.Complemento = "Valor ref: Compra de imobilizado";


Lancamento lancamento2 = new Lancamento();
lancamento2.Debito_Credito = "C";
lancamento2.Valor = 150;
lancamento2.Complemento = "Valor ref: venda de alguma coisa";


lancamento1.ExibirLancamento();
lancamento2.ExibirLancamento();