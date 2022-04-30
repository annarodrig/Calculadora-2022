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
    //****SOMA****
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
   
    //****SUBTRAÇÃO****
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

    //****MULTIPLICAÇÃO****  
    case "x":
     Console.WriteLine("Você selecionou multiplicação");

     double multiplicação, multiplicaçãoA, multiplicaçãoB;

     Console.WriteLine("Digite os valores para A * B :");
     
     Console.Write("A =");
     multiplicaçãoA = Convert.ToDouble(Console.ReadLine()!);
      
     Console.Write("B =");
     multiplicaçãoB = Convert.ToDouble(Console.ReadLine()!);
     
     multiplicação = multiplicaçãoA - multiplicaçãoB;
     
     Console.WriteLine($"Resultado da multiplicação: {multiplicaçãoA} X {multiplicaçãoB} = {multiplicação}");
       
       break;
    
    //****DIVISÃO**** 
    case "/":
     Console.WriteLine("Você selecionou Divisão");

     double divisao, divisãoA, divisãoB;

     Console.WriteLine("Digite os valores para A / B :");
     
     Console.Write("A =");
     divisãoA = Convert.ToDouble(Console.ReadLine()!);
      
     Console.Write("B =");
     divisãoB = Convert.ToDouble(Console.ReadLine()!);
     
     divisao = divisãoA - divisãoB;
     
     Console.WriteLine($"Resultado da dividido: {divisãoA} / {divisãoB} = {divisao}");
       
       break;

    default:
        Console.WriteLine("Você selecionou uma opção inválida.");
    break;   
}
