using System;
using System.Collections.Generic;
using EscolaDeRock.Models;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock
{
    enum FormacaoEnum : int
    {
        Trio = 3,
        Quarteto
    };

    enum instrumentosEnum : int
    {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLAO,
    };

    enum CategoriaEnum : int{
        HARMONIA,
        PERCUSSAO,
        MELODIA
    };
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>()
            {
                "  - 0            ",
                "  - 1          "
            };

            int opcoesFormacaoSelecionada = 0;
            string menuBar = "===================================";

            do
            {
                bool formaçaoEscolhida = false;
                
                do
                {
                    #region Area do menu
                    Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(" Seja bem-vind@!         ");
                    Console.WriteLine(" Escolha uma formação:    ");
                    Console.ResetColor();
                    Console.WriteLine(menuBar);
                    for( int i = 0; i<opcoesFormacao.Count; i++)
                    {
                        string titulo = itensMenuPrincipal[i];
                        if(opcoesFormacaoSelecionada == i)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(opcoesFormacao[opcoesFormacaoSelecionada].Replace("-",">").Replace(i.ToString(), titulo));
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(),titulo));
                        }
                    }
                    
                    var key = Console.ReadKey(true).Key;

                    switch(key)
                    {
                        case ConsoleKey.UpArrow:
                        opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == 0 ? opcoesFormacaoSelecionada : -- opcoesFormacaoSelecionada;
                        break;
                        case ConsoleKey.DownArrow:
                        opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == opcoesFormacao.Count -1 ?  opcoesFormacaoSelecionada : -- opcoesFormacaoSelecionada;
                        break;
                        case ConsoleKey.Enter:
                        formaçaoEscolhida = true;
                        break;
                        
                    }
                    #endregion
                } while(formaçaoEscolhida);

                bool bandaCompleta = false;
                int vagas = 0;

                #region Adiciona os instrumentos a formação escolhida.

                switch (opcoesFormacaoSelecionada)
                {
                    #region Cadastro de instrumentos para os trios.
                    case 0:
                        vagas = 2;
                        do
                        {
                            ExibirMenuDeInstrumentos();

                            Console.Write($"Digite código do instrumento de Harmonia: ");
                            int codigo = int.Parse(Console.ReadLine());
                            var instrumento = Deposito.Instrumentos[codigo];

                            Type interfaceEncontrada = instrumento.GetType().GetInterface("IHarmonia");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ColocarNaBanda((IHarmonia)instrumento);
                            }
                            else
                            {
                                Console.WriteLine("O instrumento selecionado não é de Harmonia.");
                                continue;
                            }

                            Console.Write($"Digite código do instrumento de Percussao: ");
                            codigo = int.Parse(Console.ReadLine());
                            instrumento = Deposito.Instrumentos[codigo];
                            interfaceEncontrada = instrumento.GetType().GetInterface("IPercussao");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ColocarNaBanda((IPercussao)instrumento);
                            }
                            else
                            {
                                Console.WriteLine("O instrumento selecionado não é de Percussao."); 
                                continue;
                            }

                            if (vagas == 0)
                            {
                                bandaCompleta = true;
                            }

                        } while (!bandaCompleta);

                        
                        System.Console.WriteLine("Sua banda está completa!");
                        Console.ReadLine();
                        break;
                    #endregion

                    #region Cadastro de instrumentos para quartetos.
                    case 1:
                        vagas = 3;
                        do
                        {

                            ExibirMenuDeInstrumentos();
                            System.Console.Write($"Digite o código do instrumento para a categoria Harmonia: ");
                            int codigo = int.Parse(Console.ReadLine());
                            var instrumento = Deposito.Instrumentos[codigo];
                            Type interfaceEncontrada = instrumento.GetType().GetInterface("IHarmonia");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ColocarNaBanda((IHarmonia)instrumento);
                            }
                            else
                            {
                                Console.WriteLine("O instrumento selecionado não é de Harmonia.");
                                continue;
                            }

                            System.Console.Write($"Digite o código do instrumento para a categoria Percussao:");
                            codigo = int.Parse(Console.ReadLine());
                            instrumento = Deposito.Instrumentos[codigo];
                            interfaceEncontrada = instrumento.GetType().GetInterface("IPercussao");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ColocarNaBanda((IPercussao)instrumento);
                            }
                            else
                            {
                                Console.WriteLine("O instrumento selecionado não é de Percussão.");
                                continue;
                            }

                            System.Console.Write($"Digite o código do instrumento para a categoria Melodia:");
                            codigo = int.Parse(Console.ReadLine());
                            instrumento = Deposito.Instrumentos[codigo];
                            interfaceEncontrada = instrumento.GetType().GetInterface("IMelodia");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ColocarNaBanda((IMelodia)instrumento);
                            }
                            else
                            {
                                Console.WriteLine("O instrumento selecionado não é de Melodia.");
                                continue;
                            }

                            if (vagas == 0)
                            {
                                bandaCompleta = true;
                            }

                        } while (!bandaCompleta);
                        System.Console.WriteLine("Sua banda está completa!");
                        Console.ReadLine();
                        break;
                    #endregion

                }
                #endregion
                Console.WriteLine("Deseja montar outra configuração? (S/N)");
                string opcao = Console.ReadLine().ToLower();

                if(opcao == "n")
                {
                    querSair = true;
                }

            } while (!querSair);
        }
        

        #region Adiciona instrumentos na banda.
        public static bool ColocarNaBanda(IHarmonia harmonia)
        {
            harmonia.TocarAcordes();
            System.Console.WriteLine(harmonia.GetType().BaseType + " foi incluído");
            return true;
        }

        public static bool ColocarNaBanda(IPercussao percussao)
        {
            percussao.ManterORitmo();
            System.Console.WriteLine(percussao.GetType().BaseType + " foi incluído");
            return true;
        }

        public static bool ColocarNaBanda(IMelodia melodia)
        {
            melodia.TocarSolo();
            System.Console.WriteLine(melodia.GetType().BaseType + " foi incluído");
            return true;
        }
        #endregion

        public static void DestacarOpcao(string opcao)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(opcao);
            Console.ResetColor();
        }

        public static void ExibirMenuDeInstrumentos()
        {
            var instrumentos = Enum.GetNames(typeof(instrumentosEnum));
            int codigo = 1;
            string menuInstrumentoBorda = "##############################";

            System.Console.WriteLine(menuInstrumentoBorda);
            System.Console.WriteLine("#                            #");
            System.Console.WriteLine("#        Instrumentos        #");
            System.Console.WriteLine("#                            #");
            System.Console.WriteLine(menuInstrumentoBorda);

            foreach (var instrumento in instrumentos)
            {
                System.Console.WriteLine($"  {codigo++}.{TratarTituloMenu(instrumento)}");
            }

            System.Console.WriteLine(menuInstrumentoBorda);
        }

        public static void ExibirMenuDeCategorias()
        {
            var categorias = Enum.GetNames(typeof(CategoriaEnum));
            int codigo = 1;
            string menuInstrumentoBorda = "##############################";
            System.Console.WriteLine(menuInstrumentoBorda);
            System.Console.WriteLine("#          Categorias        #");

            foreach (var categoria in categorias)
            {

                System.Console.WriteLine($"  {codigo++}.{TratarTituloMenu(categoria)}");
            }

            System.Console.WriteLine(menuInstrumentoBorda);

        }

        public static string TratarTituloMenu(string titulo)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        }
    }
}
