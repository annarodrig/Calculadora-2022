string opcaoDesejada;

Console.WriteLine("-- Calculadora 4 operações  --\n");

Console.WriteLine("( + )Soma");
Console.WriteLine("( - )Substração");
Console.WriteLine("( x )Multiplicação");
Console.WriteLine("( / )Divisão");

Console.Write("\nSelecione a opção desejada:");
opcaoDesejada = Console.ReadLine()!;


switch (opcaoDesejada)
{
    //****CALCULA SOMA****
    case "+" :
     Console.WriteLine("Você selecionou soma");
     
     double soma, somaA, somaB;
       
     Console.WriteLine("Digite os valores para A + B :");
      
     Console.Write("A =");
     somaA = Convert.ToDouble(Console.ReadLine()!);
      
     Console.Write("B =");
     somaB = Convert.ToDouble(Console.ReadLine()!);

     soma = somaA + somaB;

     Console.WriteLine($"Resultado da soma: {somaA} + {somaB} = {soma}");

       break;
   
    //****CALCULA SUBTRAÇÃO****
    case "-":
     Console.WriteLine("Você selecionou subtração");

     double subtracao, subtracaoA, subtracaoB;
    
     Console.WriteLine("Digite os valores para A - B :");
     
     Console.Write("A =");
     subtracaoA = Convert.ToDouble(Console.ReadLine()!);
      
     Console.Write("B =");
     subtracaoB = Convert.ToDouble(Console.ReadLine()!);
     
     subtracao = subtracaoA - subtracaoB;
     
     Console.WriteLine($"Resultado da subtracao: {subtracaoA} - {subtracaoB} = {subtracao}");

       break;

    //****CALCULA MULTIPLICAÇÃO****  
    case "x":
     Console.WriteLine("Você selecionou multiplicação");

     double multiplicacao, multiplicacaoA, multiplicacaoB;

     Console.WriteLine("Digite os valores para A * B :");
     
     Console.Write("A =");
     multiplicacaoA = Convert.ToDouble(Console.ReadLine()!);
      
     Console.Write("B =");
     multiplicacaoB = Convert.ToDouble(Console.ReadLine()!);
     
     multiplicacao = multiplicacaoA * multiplicacaoB;
     
     Console.WriteLine($"Resultado da multiplicação: {multiplicacaoA} X {multiplicacaoB} = {multiplicacao}");
       
       break;
    
    //****CALCULA DIVISÃO**** 
    case "/":
     Console.WriteLine("Você selecionou Divisão");

     double divisao, divisaoA, divisaoB;

     Console.WriteLine("Digite os valores para A / B :");
     
     Console.Write("A =");
     divisaoA = Convert.ToDouble(Console.ReadLine()!);
      
     Console.Write("B =");
     divisaoB = Convert.ToDouble(Console.ReadLine()!);
     
     divisao = divisaoA - divisaoB;
     
     Console.WriteLine($"Resultado da dividido: {divisaoA} / {divisaoB} = {divisao}");
       
       break;

    default:
        Console.WriteLine("Você selecionou uma opção inválida.");
    break;   
}
