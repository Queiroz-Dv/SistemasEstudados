using System;

namespace Treinojunior.ProjetosMedios
{
    class CalculoSalario : MenuPrincipal
    {
        public CalculoSalario()
        {
            //Tamanho da tela
            Console.SetWindowSize(100, 20);
            //Nome de cima da tela
            Console.Title = "Cálculo Salario";
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static int Menu()
        {

            while (true)
            {
                Console.Clear();
                Centralizar("==== Bem Vindo ao Diário de Sistemas ====\n");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Linha();
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 0. Voltar  <<               || "));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 1. Calcular Salario         || "));
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                Linha();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\n{0}", AlinhaTexto(36, "Digite o que deseja fazer: ", "L"));
                try
                {
                    //Coleta os dados do menu principal
                    int valor = int.Parse(Console.ReadLine());
                    switch (valor)
                    {
                        case 0:
                            //Sai do programa
                            Centralizar("Obrigado por testar meu sistema. Volte sempre!");
                            Centralizar("Pressione qualquer tecla para voltar ao menu principal");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 1:

                            // Executa os procedimentos
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Linha();
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| Digite o salário mínimno:                     || "));
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Linha();
                            Console.BackgroundColor = ConsoleColor.Black;
                            double getSalarioMinimo = double.Parse(Console.ReadLine());

                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Linha();
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $"|| Digite o salário mínimno: {getSalarioMinimo}    || "));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| Digite as horas trabalhadas:     || "));
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Linha();
                            Console.BackgroundColor = ConsoleColor.Black;
                            double getHorasTrabalhadas = double.Parse(Console.ReadLine());


                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Linha();
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $"|| Digite o salário mínimno: {getSalarioMinimo}           || "));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $"|| Digite as horas trabalhadas: {getHorasTrabalhadas}        || "));
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Linha();
                            Console.BackgroundColor = ConsoleColor.Black;
                            string getCategorias = Categorias();


                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Linha();
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $"|| Digite o salário mínimno: {getSalarioMinimo}         || "));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $"|| Digite as horas trabalhadas: {getHorasTrabalhadas}      || "));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $"|| Digite o salário mínimno: {getCategorias}           || "));
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Linha();
                            Console.BackgroundColor = ConsoleColor.Black;
                            string getTurnos = Turnos();
                            if (getTurnos == "Manhã" || getTurnos == "Tarde" || getTurnos == "Noite")
                            {
                                Centralizar("Opção inválida. Escolha os dados corretamente");
                                continue;
                            }
                            else
                            {
                                CalculoSalario calcular = new CalculoSalario();
                                calcular.Processamento(getCategorias, getTurnos, getHorasTrabalhadas, getSalarioMinimo);

                            }
                    }
                    return valor;
                }
                catch (FormatException)
                {
                    return 0;
                }
            }
        }
        private void Processamento(string categoria, string turno, double horasTrabalhadas, double valorSalarioMinimo)
        {
            double valorCoeficiente = GetCoeficiente(turno, valorSalarioMinimo);
            double valorGratificacao = GetGratificacao(turno, horasTrabalhadas);
            double valorSalarioBruto = horasTrabalhadas * valorCoeficiente;
            double valorImposto = GetValorImposto(categoria, valorSalarioBruto);
            double valorAuxilioAlimentacao = GetValorAuxilioAlimentacao(categoria, valorSalarioBruto, valorSalarioMinimo);
            double valorSalarioLiquido = (valorSalarioBruto + (valorGratificacao + valorAuxilioAlimentacao)) - valorImposto;

            ApresentarResultados(valorCoeficiente, valorSalarioBruto,
                                 valorImposto, valorGratificacao,
                                 valorAuxilioAlimentacao, valorSalarioLiquido);

        }

        private void ApresentarResultados(double valorCoeficiente, double valorSalarioBruto, double valorImposto, double valorGratificacao, double valorAuxilioAlimentacao, double valorSalarioLiquido)
        {
            throw new NotImplementedException();
        }

        private double GetValorAuxilioAlimentacao(string categorias, double valorSalarioBruto, double valorSalarioMinimo)
        {
            throw new NotImplementedException();
        }

        private  double GetValorImposto(string categorias, double valorSalarioBruto)
        {
            throw new NotImplementedException();
        }

        private  double GetGratificacao(string turno, double horasTrabalhadas)
        {
            throw new NotImplementedException();
        }

        private  double GetCoeficiente(string turno, double salarioMinimo)
        {

            double valorCoefiente = 0;
            switch (turno)
            {
                case "Manhã":
                    valorCoefiente = salarioMinimo * 0.01;
                    break;
                case "Tarde":
                    valorCoefiente = salarioMinimo * 0.02;
                    break;
                case "Noite":
                    valorCoefiente = salarioMinimo * 0.03;
                    break;
            }
            return valorCoefiente;
        }

        private static string Turnos()
        {

            Centralizar("Escolha o turno: 1.Manhã | 2.Tarde | 3.Noite ");
            int tr = int.Parse(Console.ReadLine());
            if (tr == 1)
            {
                string turno;
                string turnoManha = "Manhã";
                return turno = turnoManha;
            }
            else if (tr == 2)
            {
                string turno;
                string turnoTarde = "Tarde";
                return turno = turnoTarde;
            }
            else if (tr == 3)
            {
                string turno;
                string turnoNoite = "Noite";
                return turno = turnoNoite;
            }
            else
            {
                string turno = "Error. Nenhuma das opções selecionadas.";
                Centralizar(turno);
                return turno;
            }

        }

        private static string Categorias()
        {
            Centralizar("Escolha a categoria: 1.Calouro | 2.Veterano");
            int categ = int.Parse(Console.ReadLine());
            if (categ == 1)
            {
                string categoria;
                string ct = "Calouro";
                return categoria = ct;
            }
            else
            {
                string categoria;
                string ct = "Veterano";
                return categoria = ct;

            }
        }
    }
}
