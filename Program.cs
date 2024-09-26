// Lanchonete

int lancheCarne = 20,lancheFrango = 16,batata = 6, refrigerante = 4, refrigeranteZero = 6, salada = 2, maionese = 1, preco = 0;
int quantia, qtdLancheCarne = 0, qtdLancheFrango = 0, qtdBatata = 0, qtdRefrigerante = 0, qtdRefrigeranteZero = 0, qtdSalada = 0, qtdMaionese = 0;
string opcao,opcao2,respostaUsuario;
var pedido = 0;

Console.WriteLine("BEM VINDO, O SENHOR DESEJA FAZER UM PEDIDO? \n Opção sim: s \n Opção não: n");

respostaUsuario = Console.ReadLine().ToLower();

while (respostaUsuario == "s")
{
    Console.Clear();
    Console.WriteLine("Cardapio: \n digite [1] para lanche de carne \n digite [2] para lanche de frango \n digite [3] para batata frita \n digite [4] para refrigerante \n digite [5] para finalizar pedido");

    if (preco != 0)
    {
        Console.WriteLine("o valor atual do seu pedido é: R$" + preco);
    }

    pedido = Convert.ToInt32(Console.ReadLine());

    switch (pedido)
    {
        case 1:
            Console.WriteLine("LANCHE DE CARNE \n -> DESEJA ADICIONAR SALADA? (s ou n)");
            opcao = Console.ReadLine().ToLower();

            if (opcao == "s")
            {
                Console.WriteLine("Quantos adicionais de salada você deseja? ");
                quantia = Convert.ToInt32(Console.ReadLine());
                preco += salada * quantia;
                qtdSalada += quantia;
            }

            Console.WriteLine(" -> DESEJA ADICIONAR MAIONESE? (s ou n)");
            opcao2 = Console.ReadLine().ToLower();

            if (opcao2 == "s")
            {
                Console.WriteLine("Quantos adicionais de maionese você deseja? ");
                quantia = Convert.ToInt32(Console.ReadLine());
                preco += maionese * quantia;
                qtdMaionese += quantia;
            }

            preco += lancheCarne;
            qtdLancheCarne++;

            break;

        case 2:
            Console.WriteLine("LANCHE DE FRANGO \n -> DESEJA ADICIONAR SALADA? (s ou n)");
            opcao = Console.ReadLine().ToLower();

            if (opcao == "s")
            {
                Console.WriteLine("Quantos adicionais de salada você deseja?");
                quantia = Convert.ToInt32(Console.ReadLine());
                preco += salada * quantia;
                qtdSalada+= quantia;
            }

            Console.WriteLine("-> DESEJA ADICIONAR MAIONESE? (s ou n)");
            opcao2 = Console.ReadLine().ToLower();

            if (opcao2 == "s")
            {
                Console.WriteLine("Quantos adicionais de maionese você deseja?");
                quantia = Convert.ToInt32(Console.ReadLine());
                preco += maionese * quantia;
                qtdMaionese += quantia;
            }

            preco += lancheFrango;
            qtdLancheFrango++;

            break;

        case 3:
            Console.WriteLine("BATATA FRITA \n -> deseja adicionar maionese? (s ou n)");
            opcao = Console.ReadLine().ToLower();

            preco += batata;
            qtdBatata ++;

            if (opcao == "s")
            {
            Console.WriteLine("Quantos adicionais de maionese você deseja?");
            quantia = Convert.ToInt32(Console.ReadLine());
                preco += maionese * quantia;
                qtdMaionese+= quantia;
            }
            break;

        case 4:
            Console.WriteLine("REFRIGERANTE \n -> REFRIGERANTE SEM AÇUCAR? (s ou n)");
            opcao = Console.ReadLine().ToLower();

            if (opcao == "s")
            {
                Console.WriteLine("Quantos Refrigerantes zero você deseja?");
                quantia = Convert.ToInt32(Console.ReadLine());
                preco += refrigeranteZero * quantia;
                qtdRefrigeranteZero+= quantia;
            }
            else
            {
                Console.WriteLine("Quantos Refrigerantes você deseja?");
                quantia = Convert.ToInt32(Console.Read());
                preco += refrigerante * quantia;
                qtdRefrigerante++;
            }
            break;

        case 5:

            Console.WriteLine("Confirmar pedido.\n  \n [1] - para Continuar o pedido.\n [2] - para Finalizar o pedido.");

            respostaUsuario = Console.ReadLine().ToLower();
            if (respostaUsuario == "2");
            {
                Console.WriteLine(" ___________________________________");
                Console.WriteLine("|        N O T A   F I S C A L      |");
                Console.WriteLine("|___________________________________|");
                Console.WriteLine(" ");
                Console.WriteLine("Lanche de Carne:    " + qtdLancheCarne);
                Console.WriteLine("Lanche de Frango:   " + qtdLancheFrango);
                Console.WriteLine("Batata:             " + qtdBatata);
                Console.WriteLine("Refrigerante:       " + qtdRefrigerante);
                Console.WriteLine("Refrigerante Zero:  " + qtdRefrigeranteZero);
                Console.WriteLine("Adicional Salada:   " + qtdSalada);
                Console.WriteLine("Adicional Maionese: " + qtdMaionese);
                Console.WriteLine(" ");
                Console.WriteLine("Valor Toral:        R$" + preco);
            }
            break;

        default:
            Console.WriteLine("opção invalida!");
            break;
    }
}
Console.WriteLine("Ok, obrigado, tenha um otimo dia");