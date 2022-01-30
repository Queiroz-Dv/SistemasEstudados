﻿using FolhadePagamento;
using System;
using Treinojunior.ProjetosGrandes.SistemaConsumoEnergia;
using Treinojunior.WindowsFormsSistemas.DataSetTipado;
using Treinojunior.WindowsFormsSistemas.DataSetTipado.Forms.CRUDs;
using Treinojunior.WindowsFormsSistemas.SistemaArquivamento;
using ViewProject;

namespace Treinojunior.ProjetosGrandes
{
    class ProjetosWindowsForms : MenuPrincipal
    {
        public ProjetosWindowsForms()
        {
            //Tamanho da tela
            Console.SetWindowSize(100, 20);
            //Nome de cima da tela
            Console.Title = "Projetos Windows Form";
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static int Menu()
        {
            while (true)
            {
                Console.Clear();
                Centralizar("==== Bem Vindo ao Portfólio de Sistemas Queiroz ====\n");
                Centralizar("Hoje é " + DateTime.Now.ToLongDateString());
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Linha();
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "0. Voltar para projetos de pequeno porte <<                        "));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "1. Sistema de Consumo de Energia                                   "));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "2. Sistema de Reajuste Salarial                                    "));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "3. Sistema Gerador de Arquivo                                      "));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "4. Sistema de Gestão de Fornecedores(MVC) - (Necessário Refatorar) "));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "5. Sistema DataSet Tipado                                          "));
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                Linha();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\n{0}", AlinhaTexto(36, "Escolha uma das opções de estudos realizados: ", "L"));
                try
                {
                    int valor = int.Parse(Console.ReadLine());
                    switch (valor)
                    {
                        case 0:
                            Console.Clear();
                            break;
                        case 1:
                            new ConsumoEnergia().ShowDialog();
                            continue;
                        case 2:
                            new FormLeituraArquivo().ShowDialog();
                            continue;
                        case 3:
                            new GeradorArquivo().ShowDialog();
                            continue;
                        case 4:
                            new MenuAdm().ShowDialog();
                            continue;
                        case 5:
                            new MenuDataSetTipado().ShowDialog();
                            continue;
                        default:
                            Centralizar("Opção inválida.");
                            Console.ReadKey();
                            continue;
                    }
                    return valor;
                }
                catch (FormatException)
                {
                    return 0;
                }
            }
        }
    }
}
