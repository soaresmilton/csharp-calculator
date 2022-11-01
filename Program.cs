namespace Calculator // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Soma()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      float result = v1 + v2;

      Console.WriteLine($"{v1} + {v2} = {result}");

      Console.ReadKey();
      Menu();
    }

    static void Subtracao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());


      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      float result = v1 - v2;

      Console.WriteLine($"{v1} - {v2} = {result}");

      Console.ReadKey();

      Menu();
    }

    static void Divisao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      float result = v1 / v2;

      Console.WriteLine($"{v1} / {v2} = {result}");

      Console.ReadKey();

      Menu();
    }

    static void Multiplicacao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      float result = v1 * v2;

      Console.WriteLine($"{v1} * {v2} = {result}");

      Console.ReadKey();

      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("Selecione uma das opções a seguir.");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("5 - Sair da aplicação");

      Console.WriteLine("-------------------");

      Console.WriteLine("Digite uma opção do menu acima:");
      short menuOptions = short.Parse(Console.ReadLine());

      switch (menuOptions)
      {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
      }
    }
  }
}