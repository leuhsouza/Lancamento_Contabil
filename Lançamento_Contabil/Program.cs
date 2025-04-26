
Lancamento lancamento1 = new Lancamento();
lancamento1.Debito_Credito = "D";
lancamento1.Valor = 150;
lancamento1.Complemento = "Valor ref: Compra de imobilizado";
lancamento1.Conciliado = true;
lancamento1.Data = "25/04/2025";


Lancamento lancamento2 = new Lancamento();
lancamento2.Debito_Credito = "C";
lancamento2.Valor = 150;
lancamento2.Complemento = "Valor ref: venda de alguma coisa";
lancamento2.Conciliado = false;
lancamento2.Data = "01/01/2025";



lancamento1.ExibirLancamento();
lancamento2.ExibirLancamento();