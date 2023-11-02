// EXERCICIO 1
//public class Graduacao
//{
//    public int Matricula { get; set; }
//    public string Nome { get; set; }
//    public int CodigoCurso { get; set; } // 1- ARQ = 450 // 2- SI = 650 // 3- ENG= 850 // 4- BIOMED = 750
//    public float Mensalidade { get; set; }

//}

//public class Pos_Graduacao : Graduacao
//{
//    public string LinhaPesquisa { get; set; }
//    public string NomeOrientador { get; set; }
//    public float ValorBolsa { get; set; }

//    public float MensalidadeComDesconto()
//    {
//        return Mensalidade - ValorBolsa;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // GRADUANDO
//        Graduacao graduando = new Graduacao();

//        // GRADUANDO
//        Console.WriteLine("1- ARQUITETURA // 2- SISTEMAS DE INFORMAÇÃO // 3- ENGENHARIA // 4- BIOMED");
//        do
//        {
//            Console.Write("Informe a graduação desejada: ");
//            graduando.CodigoCurso = int.Parse(Console.ReadLine());
//        } while (graduando.CodigoCurso < 0 || graduando.CodigoCurso > 4);


//        switch (graduando.CodigoCurso)
//        {
//            case 1:
//                graduando.Mensalidade = 450;
//                break;
//            case 2:
//                graduando.Mensalidade = 650;
//                break;
//            case 3:
//                graduando.Mensalidade = 850;
//                break;
//            case 4:
//                graduando.Mensalidade = 750;
//                break;
//            default:
//                Console.WriteLine("Código inválido!");
//                break;
//        }

//        Console.Write("Informe o número de matrícula: ");
//        graduando.Matricula = int.Parse(Console.ReadLine());

//        Console.Write("Informe o seu nome: ");
//        graduando.Nome = Console.ReadLine();

//        Console.WriteLine("O aluno {0} foi inscrito no curso e o valor da sua matrícula, é: {1:C}\n", graduando.Nome, graduando.Mensalidade);

//        // POS GRADUANDO

//        Pos_Graduacao pos_graduando = new Pos_Graduacao();

//        Console.WriteLine("1- ARQUITETURA // 2- SISTEMAS DE INFORMAÇÃO // 3- ENGENHARIA // 4- BIOMED");
//        do
//        {
//            Console.Write("Informe a pós graduação desejada: ");
//            pos_graduando.CodigoCurso = int.Parse(Console.ReadLine());
//        } while (pos_graduando.CodigoCurso < 0 || pos_graduando.CodigoCurso > 4);


//        switch (pos_graduando.CodigoCurso)
//        {
//            case 1:
//                pos_graduando.Mensalidade = 450;
//                break;
//            case 2:
//                pos_graduando.Mensalidade = 650;
//                break;
//            case 3:
//                pos_graduando.Mensalidade = 850;
//                break;
//            case 4:
//                pos_graduando.Mensalidade = 750;
//                break;
//            default:
//                Console.WriteLine("Código inválido!");
//                break;
//        }

//        Console.Write("Informe o número de matrícula: ");
//        pos_graduando.Matricula = int.Parse(Console.ReadLine());

//        Console.Write("Informe o seu nome: ");
//        pos_graduando.Nome = Console.ReadLine();

//        Console.Write("Informe a linha de pesquisa: ");
//        pos_graduando.LinhaPesquisa = Console.ReadLine();

//        Console.Write("Informe o nome do orientador: ");
//        pos_graduando.NomeOrientador = Console.ReadLine();

//        Console.Write("Informe o valor da sua bolsa de estudos (EM REAIS): ");
//        pos_graduando.ValorBolsa = float.Parse(Console.ReadLine());

//        Console.WriteLine("O aluno {0} foi inscrito no curso e o valor da sua matrícula, é: {1:C}", pos_graduando.Nome, pos_graduando.MensalidadeComDesconto());
//    }
//}

// EXERCICIO 2
//public class Veiculo
//{
//    public string marca { get; set; }
//    public string modelo { get; set; }
//    public int ano_fabricacao { get; set; }
//    public string cor { get; set; }
//}

//public class Carro : Veiculo
//{
//    public int quantidade_portas { get; set; }
//    public string transmissao { get; set; }
//}

//public class Motocicleta : Veiculo
//{
//    public int cilindradas { get; set; }
//    public string tipo_partida { get; set; }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Carro carro = new Carro();
//        carro.marca = "Audi";
//        carro.modelo = "Q5";
//        carro.ano_fabricacao = 2023;
//        carro.cor = "Cinza espacial";
//        carro.quantidade_portas = 5;
//        carro.transmissao = "Automático";

//        Console.WriteLine($"O carro {carro.marca} de modelo {carro.modelo}, fabricado em {carro.ano_fabricacao} de cor {carro.cor}, possui {carro.quantidade_portas} portas, é {carro.transmissao}");

//        Motocicleta moto = new Motocicleta();
//        moto.marca = "Ducati";
//        moto.modelo = "Hyper Naked";
//        moto.ano_fabricacao = 2023;
//        moto.cor = "Preto";
//        moto.cilindradas = 1100;
//        moto.tipo_partida = "Elétrica";

//        Console.WriteLine($"A motocicleta {moto.marca} de modelo {moto.modelo}, fabricado em {moto.ano_fabricacao} de cor {moto.cor}, possui {moto.cilindradas} cilindradas e partida {moto.tipo_partida}");

//    }
//}