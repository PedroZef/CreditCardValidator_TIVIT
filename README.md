# Validador de Cartão de Crédito

Esta é uma aplicação de desktop .NET para identificar a bandeira do cartão de crédito (Visa, MasterCard, Amex, etc.) com base no número do cartão.

## Interação

A aplicação utiliza uma interface gráfica para a entrada de dados. Ao ser executado, um formulário de entrada é exibido:

1. Uma caixa de diálogo com o título "Validador de Cartão de Crédito" solicitará o número do cartão.
2. Digite ou cole o número do cartão de crédito no campo de texto.
3. Clique em "OK" para ver a bandeira do cartão ou "Cancelar" (ou deixe o campo em branco) para sair.
4. O resultado será exibido em uma caixa de mensagem com o título "Resultado".
5. A aplicação continuará pedindo novos números de cartão até que o formulário de entrada seja fechado ou cancelado.

6. ## ![Imagem da instrução](./CreditCardValidator/resources/img/base.png)

7.  ## ![Imagem da instrução](./CreditCardValidator/resources/slogan.jpg) 

## Tecnologias Utilizadas

- .NET 8.0
- C#
- Windows Forms

## Como executar

1. Navegue até o diretório `CreditCardValidator`:

    ```
    cd CreditCardValidator
    ```

2. Execute a aplicação:

    ```
    dotnet run 
    ```

## OU

    ```
    dotnet run --project CreditCardValidator
    ```

A aplicação abrirá uma janela para que você insira o número do cartão.

## Bandeiras de Cartão Suportadas

A aplicação identifica as seguintes bandeiras de cartão de crédito com base nos seus números:

| Bandeira         | Começa com                               |
| ---------------- | ---------------------------------------- |
| Visa             | 4                                        |
| MasterCard       | 51-55, 2221-2720                         |
| American Express | 34, 37                                   |
| Discover         | 6011, 65, 644-649                        |
| Hipercard        | 6062                                     |
| Elo              | 5067, 509, 6363, 650, 6516, 6550         |


**Observação:** 

### Para sair do program [!Clique Crtl+c ou OK no formulario]

A aplicação **não** valida o número do cartão de crédito (por exemplo, usando o algoritmo de Luhn) nem lida com informações de segurança como senhas ou códigos de segurança (CVV). A identificação é feita apenas com base nos dígitos iniciais do número do cartão.
