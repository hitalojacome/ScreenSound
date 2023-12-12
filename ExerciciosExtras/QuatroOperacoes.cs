Console.Clear();
Console.WriteLine("Este programa visa exibir o resultado das quatro principais operações matemáticas");
Console.WriteLine("(soma, subtração, divisão e multiplicação)");
quatroOperacoes();

void quatroOperacoes()
{
    Console.Write("\nInsira o primeiro valor: ");
    double a = double.Parse(Console.ReadLine()!); 
    Console.Write("Agora o segundo valor: ");
    double b = double.Parse(Console.ReadLine()!);

    soma(a, b);
    subtracao(a, b);
    divisao(a, b);
    multiplicacao(a, b);
}

void soma(double a, double b)
{
    double resultadoSoma = a + b;
    Console.WriteLine($"\nSoma: {a} + {b} = {resultadoSoma:F2}");
}

void subtracao(double a, double b)
{
    double resultadoSubtracao = a - b;
    Console.WriteLine($"Subtração: {a} - {b} = {resultadoSubtracao:F2}");
}

void divisao(double a, double b)
{
    double resultadoDivisao = a / b;
    Console.WriteLine($"Divisão: {a} / {b} = {resultadoDivisao:F2}");
}

void multiplicacao(double a, double b)
{
    double resultadoMultiplicasao = a * b;
    Console.WriteLine($"Multiplicação: {a} * {b} = {resultadoMultiplicasao:F2}");
}