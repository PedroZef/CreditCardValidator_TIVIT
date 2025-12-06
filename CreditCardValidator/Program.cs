using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;

public class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Aguardando entrada do número do cartão...");
            string numeroCartao = Interaction.InputBox("Digite o número do cartão de crédito:", "Validador de Cartão de Crédito");

            if (string.IsNullOrWhiteSpace(numeroCartao))
            {
                break;
            }

            string bandeiraCartao = IdentificarBandeiraCartao(numeroCartao);
            Console.WriteLine($"Bandeira do cartão: {bandeiraCartao}");
            MessageBox.Show($"Bandeira do cartão: {bandeiraCartao}", "Resultado");
        }
    }

    public static string IdentificarBandeiraCartao(string numeroCartao)
    {
        if (string.IsNullOrWhiteSpace(numeroCartao))
        {
            return "Número de cartão inválido";
        }

        // Remove caracteres não numéricos
        string numeroCartaoNormalizado = Regex.Replace(numeroCartao, @"\D", "");

        // Visa
        if (Regex.IsMatch(numeroCartaoNormalizado, @"^4"))
        {
            return "Visa";
        }
        // MasterCard
        else if (Regex.IsMatch(numeroCartaoNormalizado, @"^(5[1-5]|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[0-1][0-9]|2720)"))
        {
            return "MasterCard";
        }
        // American Express
        else if (Regex.IsMatch(numeroCartaoNormalizado, @"^3[47]"))
        {
            return "American Express";
        }
        // Discover
        else if (Regex.IsMatch(numeroCartaoNormalizado, @"^(6011|65|64[4-9])"))
        {
            return "Discover";
        }
        // Hipercard
        else if (Regex.IsMatch(numeroCartaoNormalizado, @"^6062"))
        {
            return "Hipercard";
        }
        // Elo
        else if (Regex.IsMatch(numeroCartaoNormalizado, @"^(5067|509|6363|650|6516|6550)"))
        {
            return "Elo";
        }

        return "Bandeira desconhecida";
    }
}

