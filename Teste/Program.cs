int menu = 0;

while (menu != 7)
{
    Console.WriteLine("|======================================================|");
    Console.WriteLine("|   Bem-vindo escolha qual exercicio você quer ver:    |");
    Console.WriteLine("|                [1] - Exercicio 1                     |");
    Console.WriteLine("|                [2] - Exercicio 2                     |");
    Console.WriteLine("|                [3] - Exercicio 3                     |");
    Console.WriteLine("|                [4] - Exercicio 4                     |");
    Console.WriteLine("|                [5] - Exercicio 5                     |");
    Console.WriteLine("|                [6] - Exercicio 6                     |");
    Console.WriteLine("|                [7] - Sair                            |");
    Console.WriteLine("|======================================================|");
    menu = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (menu)
    {
        case 1:
            // chama o ExercicioUm
            ExercicioUm();
            break;

        case 2:
            //chama o ExercicioDois
            ExerecicioDois();
            break;

        case 3:
            // chamar método para ExercicioTres
            ExercicioTres();
            break;

        case 4:
            // chamar método para ExercicioQuatro
            ExercicioQuatro();
            break;

        case 5:
            // chamar método para ExercicioCinco
            ExercicioCinco();
            break;

        case 6:
            // chamar método para ExercicioSeis
            ExercicioSeis();
            break;

        case 7:
            Console.WriteLine("Finalizando Sessão. \n\nAté Breve .");
            Console.ReadLine();
            Console.Clear();
            break;

        default:
            Console.WriteLine("Opção inválida. \n\ninforme uma das opção acima.");
            Console.ReadLine();
            Console.Clear();
            break;
    }
}

static void ExercicioUm()
{
    int submenu = 0;

    while (submenu != 4)
    {
        Console.WriteLine("|========================================================|");
        Console.WriteLine("|          Escolha qual atividade você quer vê:          |");
        Console.WriteLine("|                     [1] - Nome                         |");
        Console.WriteLine("|                     [2] - Horário                      |");
        Console.WriteLine("|                     [3] - Área do quadrado             |");
        Console.WriteLine("|                     [4] - Voltar                       |");
        Console.WriteLine("|========================================================|");
        submenu = int.Parse(Console.ReadLine());
        Console.Clear();

        switch (submenu)
        {
            case 1:
                Console.WriteLine("Informe seu nome: ");
                string nome = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Infome sua Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Informe sua altura em metros (Use , para separar os centímetros): ");
                double altura = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Informe seu peso: ");
                double peso = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Seu nome é " + nome + ", você tem " + idade + " anos, tem " + altura + "m de altura e pesa " + peso + "Kg.");
                Console.ReadLine();
                Console.Clear();
                break;

            case 2:
                Console.WriteLine("informe o horário (Só a hora sem minutos)");
                int hr = int.Parse(Console.ReadLine());
                Console.Clear();

                if (hr <= 5)
                {
                    Console.WriteLine("Vai dormir!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (hr <= 12)
                {
                    Console.WriteLine("Bom Dia!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (hr <= 18)
                {
                    Console.WriteLine("Boa tarde!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (hr <= 23)
                {
                    Console.WriteLine("Boa noite!");
                    Console.ReadLine();
                    Console.Clear();
                }
                break;

            case 3:
                Console.WriteLine("Informe o lado do quadrado: ");
                double l = double.Parse(Console.ReadLine());
                Console.Clear();
                double area = l * l;

                Console.WriteLine("Essa é a área de quadrado: " + area);
                Console.ReadLine();
                Console.Clear();
                break;

            case 4:
                Console.WriteLine("Voltando ao menu principal.");
                Console.ReadLine();
                Console.Clear();
                break;

            default:
                Console.WriteLine("Opção inválida. \n\ninforme uma das opção acima.");
                Console.ReadLine();
                Console.Clear();
                break;
        }
    }
}

static void ExerecicioDois()
{
    int submenu = 0;

    while (submenu != 3)
    {
        Console.WriteLine("|======================================================|");
        Console.WriteLine("|        Escolha qual atividade você quer vê:          |");
        Console.WriteLine("|                [1] - Média de Nota                   |");
        Console.WriteLine("|                [2] - Maior núnmero                   |");
        Console.WriteLine("|                [3] - Voltar                          |");
        Console.WriteLine("|======================================================|");
        submenu = int.Parse(Console.ReadLine());
        Console.Clear();
        
        switch (submenu)
        {
            case 1:
                Console.WriteLine("Informe a 1ª nota: ");
                float n1 = float.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Informe a 2ª nota: ");
                float n2 = float.Parse(Console.ReadLine());
                Console.Clear();

                float nf = (n1 + n2) / 2;

                if (nf >= 6)
                {
                    Console.WriteLine("Aprovado! \n\nSua nota final é: " + nf.ToString("f2"));
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Reprovado! \n\nEstude mais!!! \n\nsua nota final é: " + nf.ToString("f2"));
                    Console.ReadLine();
                    Console.Clear();
                }
                break;
            
            case 2:
                Console.WriteLine("Informe o 1º número");
                int a = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Informe o 2º número");
                int s = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Informe o 3º número");
                int d = int.Parse(Console.ReadLine());
                Console.Clear();

                if (a > s && a > d)
                {
                    Console.WriteLine("O 1º número é o maior: " + a);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (s > a && s > d)
                {
                    Console.WriteLine("O 2º número é o maior: " + s);
                    Console.ReadLine();
                    Console.Clear();
                }
                else Console.WriteLine("O 3º número é o maior: " + d);
                Console.ReadLine();
                Console.Clear();
                break;

            case 3:
                Console.WriteLine("Voltando ao menu principal.");
                Console.ReadLine();
                Console.Clear();
                break;

            default:
                Console.WriteLine("Opção inválida. \n\ninforme uma das opção acima.");
                Console.ReadLine();
                Console.Clear();
                break;
        }
    }
}

static void ExercicioTres()
{
    int submenu = 0;

    while (submenu != 3)
    {
        Console.WriteLine("|======================================================|");
        Console.WriteLine("|        Escolha qual atividade você quer vê:          |");
        Console.WriteLine("|                 [1] - Senha                          |");
        Console.WriteLine("|                 [2] - Número Impar                   |");
        Console.WriteLine("|                 [3] - Voltar                         |");
        Console.WriteLine("|======================================================|");
        submenu = int.Parse(Console.ReadLine());
        Console.Clear();

        switch (submenu)
        {
            case 1:
                Console.WriteLine("Crie uma senha de 4 numeros inteiro");
                int senha = 0;
                int senCor = int.Parse(Console.ReadLine());
                Console.Clear();

                while (senha != senCor)
                {
                    Console.WriteLine("Digite sua senha");
                    senha = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (senha != senCor)
                    {
                        Console.WriteLine("Senha Incorreta!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                Console.WriteLine("Senha correta!");
                Console.ReadLine();
                Console.Clear();
                break;

            case 2:
                Console.WriteLine("Digite um número inteiro: ");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();

                if (n == 0)
                {
                    Console.WriteLine("Não tem nenhum número impar.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                { 
                    for (int i = 1; i <= n; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("\nEsse são os números impares que tem de 0 até " + n);
                    Console.ReadLine();
                    Console.Clear();
                }
                break;
            
            case 3:
                Console.WriteLine("Voltando ao menu principal.");
                Console.ReadLine();
                Console.Clear();
                break;

            default:
                Console.WriteLine("Opção inválida. \n\ninforme uma das opção acima.");
                Console.ReadLine();
                Console.Clear();
                break;
        }
    }
}
static void ExercicioQuatro()
{
    int submenu = 0;

    while (submenu != 3)
    {
        Console.WriteLine("|======================================================|");
        Console.WriteLine("|        Escolha qual atividade você quer vê:          |");
        Console.WriteLine("|             [1] - Sequência dos nomes                |");
        Console.WriteLine("|             [2] - Soma dos números                   |");
        Console.WriteLine("|             [3] - Voltar                             |");
        Console.WriteLine("|======================================================|");
        submenu = int.Parse(Console.ReadLine());
        Console.Clear();
        
        switch (submenu)
        {
            case 1:
                Console.WriteLine("Digite o número de nomes a serem inseridos:");
                int n = int.Parse(Console.ReadLine());
                string[] nomes = new string[n];

                Console.Clear();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Digite o nome " + (i + 1) + ":");
                    nomes[i] = Console.ReadLine();
                    Console.Clear();

                }
                Console.WriteLine("Esses foram os nomes digitados: ");

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(nomes[i]);
                }
                Console.ReadLine();
                Console.Clear();
                break;
            
            case 2:
                int[] valor = new int[5];
                int soma = 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Informe um número " + (i + 1) + ": ");
                    valor[i] = int.Parse(Console.ReadLine());
                    Console.Clear();
                    soma += valor[i];
                }
                Console.WriteLine("A soma dos numeros é: " + soma);
                Console.ReadLine();
                Console.Clear();
                break;

            case 3:
                Console.WriteLine("Voltando ao menu principal.");
                Console.ReadLine();
                Console.Clear();
                break;

            default:
                Console.WriteLine("Opção inválida. \n\ninforme uma das opção acima.");
                Console.ReadLine();
                Console.Clear();
                break;

        }
    }
}
static void ExercicioCinco()
{
    int submenu = 0;

    while (submenu != 2)
    {
        Console.WriteLine("|======================================================|");
        Console.WriteLine("|        Escolha qual atividade você quer vê:          |");
        Console.WriteLine("|                    [1] - Matriz                      |");
        Console.WriteLine("|                    [2] - Voltar                      |");
        Console.WriteLine("|======================================================|");
        submenu = int.Parse(Console.ReadLine());
        Console.Clear();

        switch (submenu)
        {
            case 1:
                int[,] m;
                m = new int[4, 4];

                m[0, 0] = 1; m[1, 0] = 10; m[2, 0] = 12; m[3, 0] = 15;
                m[0, 1] = 2; m[1, 1] = 20; m[2, 1] = 22; m[3, 1] = 25;
                m[0, 2] = 3; m[1, 2] = 30; m[2, 2] = 32; m[3, 2] = 35;
                m[0, 3] = 4; m[1, 3] = 40; m[2, 3] = 42; m[3, 3] = 45;

                for (int linha = 0; linha < 4; linha++)
                {
                    for (int coluna = 0; coluna < 4; coluna++)
                    {
                        Console.Write("{0}\t", m[linha, coluna]);
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();
                Console.Clear();
                break;
            
            case 2:
                Console.WriteLine("Voltando ao menu principal.");
                Console.ReadLine();
                Console.Clear();
                break;

            default:
                Console.WriteLine("Opção inválida. \n\ninforme uma das opção acima.");
                Console.ReadLine();
                Console.Clear();
                break;
        }
    }
}

static void ExercicioSeis()
{
    int submenu = 0;

    while (submenu != 2)
    {
        Console.WriteLine("|======================================================|");
        Console.WriteLine("|        Escolha qual atividade você quer vê:          |");
        Console.WriteLine("|                 [1] - Caixa Eletrônico               |");
        Console.WriteLine("|                 [2] - Voltar                         |");
        Console.WriteLine("|======================================================|");
        submenu = int.Parse(Console.ReadLine());
        Console.Clear();

        switch (submenu)
        {
            case 1:
                Console.WriteLine("Bem-vindo XXXXXX");
                Console.ReadLine();
                Console.Clear();

                int opcoes = 0;
                double saldo = 0;

                while (saldo == 0)
                {
                    Console.WriteLine("Por favor deposite para começar: ");
                    double valor = double.Parse(Console.ReadLine());
                    saldo = saldo + valor;
                    Console.Clear();

                    if (saldo == 0)
                    {
                        Console.WriteLine("Erro deposite um valor para começar");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                while (opcoes != 4)
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("|  O que você deseja fazer?    |");
                    Console.WriteLine("|   [1] - Ver saldo            |");
                    Console.WriteLine("|   [2] - Depositar dinheiro   |");
                    Console.WriteLine("|   [3] - Sacar dinheiro       |");
                    Console.WriteLine("|   [4] - Sair                 |");
                    Console.WriteLine("================================");
                    opcoes = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (opcoes)
                    {
                        case 1:
                            verSaldo(saldo);
                            break;

                        case 2:
                            saldo = depositar(saldo);
                            break;

                        case 3:
                            saldo = sacar(saldo);
                            break;

                        case 4:
                            Console.WriteLine("Finalizando Sessão. \n\nAté Breve.");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("Opção inválida. \n\ninforme uma das opção acima.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }

                static double verSaldo(double saldo)
                {
                    Console.WriteLine("Seu saldo é: R$" + saldo);
                    Console.ReadLine();
                    Console.Clear();
                    return saldo;
                }

                static double depositar(double saldo)
                {
                    Console.WriteLine("Informe o valor do depósito");
                    double deposito = double.Parse(Console.ReadLine());
                    Console.WriteLine("Depósito realizado!");
                    saldo = saldo + deposito;
                    Console.WriteLine("\nSeu saldo agora é de: R$" + saldo);
                    Console.ReadLine();
                    Console.Clear();
                    return saldo;
                }

                static double sacar(double saldo)
                {
                    Console.WriteLine("Digite o valor do saque:");
                    double valorSaq = double.Parse(Console.ReadLine());

                    if (valorSaq > saldo)
                    {
                        Console.WriteLine("\nSaldo Insuficiente!");
                        verSaldo(saldo);
                    }
                    else
                    {
                        saldo -= valorSaq;
                        Console.WriteLine("\nSaque realizado!");
                        Console.WriteLine("\nSeu saldo agora é de: R$" + saldo);
                        Console.ReadLine();
                        Console.Clear();
                    }
                    return saldo;
                }
                break;

            case 2:
                Console.WriteLine("Voltando ao menu principal.");
                Console.ReadLine();
                Console.Clear();
                break;

            default:
                Console.WriteLine("Opção inválida. \n\ninforme uma das opção acima.");
                Console.ReadLine();
                Console.Clear();
                break;
        }
    }
}