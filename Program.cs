using System;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using TamanhoPiramides;
using Piramides.PiramideErros;

namespace Piramides
{
    public class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()

        {
            Console.Clear();
            Console.WriteLine(
            @" Qual Tipo de Piramide você deseja ver? (Ex:Piramide do Tipo minimo = 3 e Piramide do Tipo maximo = 8)");
            int valorlido = 0;
            try
            {
                valorlido = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                MeusErros.ErroDeFormato();
            }
            catch (Exception)
            {
                MeusErros.ErroGenerico();
            }
            Console.Clear();
            ContadordeValor(Convert.ToInt32(valorlido));

        }

        public static void ContadordeValor(int valorlido)
        {
            if (valorlido < 3)
            {
                MeusErros.ErroDeAlcance();
            }
            else if (valorlido > 9)
            {
                MeusErros.ErroDeAlcance();
            }
            if (valorlido == 3)
            {
                TamanhoDasPiramides.Piramidede3();
                TelaIntermediaria();
            }
            else if (valorlido == 4)
            {
                TamanhoDasPiramides.Piramidede4();
                TelaIntermediaria();
            }
            else if (valorlido == 5)
            {
                TamanhoDasPiramides.Piramidede5();
                TelaIntermediaria();
            }
            else if (valorlido == 6)
            {
                TamanhoDasPiramides.Piramidede6();
                TelaIntermediaria();
            }
            else if (valorlido == 7)
            {
                TamanhoDasPiramides.Piramidede7();
                TelaIntermediaria();
            }
            else if (valorlido == 8)
            {
                TamanhoDasPiramides.Piramidede8();
                TelaIntermediaria();
            }
        }

        public static void TelaIntermediaria()
        {
            Console.WriteLine(@"
Gostaria de voltar para o Menu?
1- Para sim .
- Qualquer outro valor para sair da aplicação.");
            int voltarmenu = 0;
            try
            {
                voltarmenu = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                MeusErros.ErroDeAlcanceTelaIntermediaria();
            }

            if
                (voltarmenu == 1)
            {
                Menu();
            }
            else if (voltarmenu != 1)
            {
                Environment.Exit(0);
            };
        }
    }
}



