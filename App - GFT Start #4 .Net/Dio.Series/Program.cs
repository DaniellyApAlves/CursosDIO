using System;
using System.Console;


namespace Dio.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
                        
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    ListaSerie();
                    break;

                    case "2":
                    InserirSerie();
                    break;
                    
                    case "3":
                    AtualizarSerie();
                    break;

                    case "4":
                    ExcluirSerie();
                    break;

                    case "5":
                    VisualizarSerie();
                    break;

                    case "c":
                    Console.Clear();
                    break;
                    
                    default:
                    throw new ArgumentOutOfRangeException();
    
                    
                }
                opcaoUsuario = ObterOpcaoUsuario
            }
        }

        private static void InserirSerie()
        {
            throw new NotImplementedException();
        }

        private static void ListaSerie()
                {
                    System.Console.WriteLine("Listar séries");
                    var Lista = repositorio.Lista();
                    if (Lista.Count == 0)
                    {
                        System.Console.WriteLine("Nenhuma série cadastrada");
                    }
                    foreach (var Serie in Lista)
                    {
                        System.Console.WriteLine("#ID {0}: = + (1)", Serie.RetornaPorId(), Serie.retornaTitulo());
                    }
                }

        private static async void InserirSerie(Console console)
        {
            System.Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
        System.Console.WriteLine("Digite o genero entre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite o título da Série: ");
        string entradaTitulo = Console.ReadLine();

        System.Console.WriteLine("Digite o ano do início da Série: ");
        string entradaAno = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite a descrição da Série: ");
        string entradaDescricao = Console.ReadLine();

        Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero (Genero)entradaGenero, 
                                        Titulo: entradaTitulo, 
                                        Ano: entradaAno, 
                                        Descricao: entradaDescricao);

        repositorio.Insere(novaSerie);
        }
        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Dio Séries a seu dispor!!");
            System.Console.WriteLine("Informe a opção desejada: ");

            System.Console.WriteLine("1- Listar séries");
            System.Console.WriteLine("2- Inserir nova série");
            System.Console.WriteLine("3- Atualizar série");
            System.Console.WriteLine("4- Excluir série");
            System.Console.WriteLine("5- Visualizar série");
            System.Console.WriteLine("c- Limpar Tela");
            System.Console.WriteLine("x- Sair");
            System.Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.ReadLine();
            return opcaoUsuario;

        }
    
    }
}
