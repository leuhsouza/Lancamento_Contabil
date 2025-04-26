
//Lancamento lancamento1 = new Lancamento();
//lancamento1.Debito_Credito = "D";
//lancamento1.Valor = 150;
//lancamento1.Complemento = "Valor ref: Compra de imobilizado";
//lancamento1.Conciliado = true;
//lancamento1.Data = "25/04/2025";
//lancamento1.Conta = 1;

//Lancamento lancamento2 = new Lancamento();
//lancamento2.Debito_Credito = "C";
//lancamento2.Valor = 150;
//lancamento2.Complemento = "Valor ref: venda de alguma coisa";
//lancamento2.Conciliado = false;
//lancamento2.Data = "01/01/2025";
//lancamento2.Conta = 3;

// aqui eu instanciei uma lista chamada caixa
Razao caixa = new Razao();


caixa.RazaoConta = 1;

Lancamento lancamento1 = new Lancamento();
lancamento1.Data = "26/04/2025";
lancamento1.Conta = 1;
lancamento1.ContaDescricao = "Caixa";
lancamento1.Debito_Credito = "D";
lancamento1.Valor = 1500;

Lancamento lancamento2 = new Lancamento();
lancamento2.Data = "22/04/2025";
lancamento2.Conta = 1;
lancamento2.ContaDescricao = "Caixa";
lancamento2.Debito_Credito = "C";
lancamento2.Valor = 1600;



caixa.AdicionarLancamento(lancamento1);
caixa.AdicionarLancamento(lancamento2);

caixa.ExibirLancamento();



//lancamento1.ExibirLancamento();
//lancamento2.ExibirLancamento();