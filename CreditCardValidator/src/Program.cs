namespace CreditCardValidator;
using System.Text.RegularExpressions;

public class CreditCardBrandIdentifier
{
    // A ordem é importante para a correspondência, dos padrões mais específicos para os mais genéricos.
    private static readonly List<(string Brand, string Pattern)> BrandPatterns = new List<(string, string)>
    {
        ("Hipercard", @"^(606282|384100|384140|384160)"),
        ("Elo", @"^(401178|401179|431274|438935|451416|457393|457631|457632|504175|506699|5067|509|627780|636297|636368|65003|6504|6505|6507|6509|6516|6550)"),
        ("Maestro", @"^(5018|5020|5038|5893|6304|6759|6761|6762|6763)"),
        ("JCB", @"^35(2[8-9]|[3-8][0-9])"),
        ("Diners Club", @"^3(0[0-5]|[689])"),
        ("American Express", @"^3[47]"),
        ("Discover", @"^(6011|64[4-9]|65)"),
        ("UnionPay", @"^62"),
        ("MasterCard", @"^(5[1-5]|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[0-1][0-9]|2720)"),
        ("Visa", @"^4")
    };

    public string IdentifyBrand(string cardNumber)
    {
        if (string.IsNullOrWhiteSpace(cardNumber))
        {
            return "Número de cartão inválido";
        }

        string normalizedCardNumber = Regex.Replace(cardNumber, @"\D", "");

        foreach (var (Brand, Pattern) in BrandPatterns)
        {
            if (Regex.IsMatch(normalizedCardNumber, Pattern))
            {
                return Brand;
            }
        }

        return "Bandeira desconhecida";
    }
}

public class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        // A splash screen é executada e, quando se fecha, a execução continua.
        Application.Run(new FormScreen());

        var identifier = new CreditCardBrandIdentifier();

        while (true)
        {
            string numeroCartao;
            using (var inputForm = new InputForm("Validador de Cartão de Crédito", "Digite o número do cartão de crédito (ou deixe em branco para sair):"))
            {
                var result = inputForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    numeroCartao = inputForm.InputValue;
                }
                else
                {
                    // O usuário clicou em Cancelar ou fechou o formulário
                    break;
                }
            }

            if (string.IsNullOrWhiteSpace(numeroCartao))
            {
                // Se o usuário clicar em OK com a caixa vazia, saia do loop.
                break;
            }

            string bandeiraCartao = identifier.IdentifyBrand(numeroCartao);
            
            Console.WriteLine($"Cartão: {numeroCartao} -> Bandeira: {bandeiraCartao}");
            MessageBox.Show($"Bandeira do cartão: {bandeiraCartao}", "Resultado");
        }
    }
}
