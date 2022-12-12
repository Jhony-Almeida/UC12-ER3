// See https://aka.ms/new-console-template for more information

//Console.Clear();
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Turma13");

using ProgBackEnd.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Jhony Almeida da Silva";
novaPf.cpf = "1547846565";
novaPf.rendimento = 7000.5f;

Console.WriteLine($"Pessoa Fisica ========================");


float resultado = novaPf.CalcularImposto(novaPf.rendimento);
Console.WriteLine(resultado);

//Console.WriteLine(novaPf.nome);
//Console.WriteLine(novaPf.cpf);
//Console.WriteLine($"---------------------------");


//Console.WriteLine($"Bem-vindo {novaPf.nome} seu cpf é:{novaPf.cpf}");

Console.WriteLine($"Pessoa Juridica ========================");


PessoaJuridica novaPj = new PessoaJuridica();

float impostoPagar = novaPj.CalcularImposto(12000.5f);
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine($"{impostoPagar.ToString("C")}");


