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
   
    case "-":
     Console.WriteLine("Você selecionou subtração");

     double subtracao, subtracaoA, subtracaoB;
    
     Console.WriteLine("Digite os valores para A + B :");
     
     Console.Write("A =");
     subtracaoA = Convert.ToDouble(Console.ReadLine()!);
      
     Console.Write("B =");
     subtracaoB = Convert.ToDouble(Console.ReadLine()!);
     
     subtracao = subtracaoA - subtracaoB;
     
     Console.WriteLine($"Resultado da subtracao: {subtracaoA} - {subtracaoB} = {subtracao}");

       break;
      

}